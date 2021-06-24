using Cyrella.ETL.Models.Dimensao;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cyrella.ETL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private IConfiguration _config;

        public HomeController(IConfiguration configuration)
        {
            _config = configuration;
        }

        /// <summary>
        /// inicializa o tratamento dos dados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                Task.WaitAll(
                  TransformCoobrigado(),
                  TransformRegiao(),
                  TransformMarca(),
                  TransformData(),
                  TransformLogNavegacao());

                await TransformPosicaoFinanceiraFato();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Converte os dados dados de coobrigado para a dimensao de cliente
        /// </summary>
        /// <returns></returns>
        private async Task TransformCoobrigado()
        {
            using (SqlConnection database = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await database.ExecuteAsync(
                @"INSERT INTO DIM_CLIENTE
                    SELECT  co.Obra,
                            co.Bloco,
                            co.Unidade,
                            co.Ativo,
                            co.PercentualParticipacao PercentualPago,
                            co.Nome,
                            co.CPF_CNPJ DocumentoCliente
                    FROM    Coobrigado co
        ");
            }
        }

        /// <summary>
        /// Converte os dados da carteira para a dimensao de regiao
        /// </summary>
        /// <returns></returns>
        private async Task TransformRegiao()
        {
            using (SqlConnection database = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                IEnumerable<DRegiao> DimensionRegiao = await database.QueryAsync<DRegiao>(
                    @"SELECT DISTINCT Regional Regiao
                        FROM    carteira
                        WHERE   regional is not null
                                AND regional <> ''
                                AND regional not in ('Rio de Janeiro (não usar)','')");

                foreach (DRegiao item in DimensionRegiao)
                {
                    database.Execute(
                     @"INSERT INTO DIM_REGIAO VALUES (@p1);", new
                     {
                         @p1 = item.Regiao
                     });
                }
            }
        }

        /// <summary>
        /// Converte os dados da carteira para a dimensao de marcas
        /// </summary>
        /// <returns></returns>
        private async Task TransformMarca()
        {
            using (SqlConnection database = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var marcas = await database.QueryAsync<Marca>(@"select distinct marca NomeMarca, Empreendimento from ex_cbr where marca is not null and marca <> ''  and Empreendimento is not null and Empreendimento <> ''");

                foreach (var item in marcas)
                    database.Execute("INSERT INTO DIM_MARCA VALUES(@P1,@P2)", new { @p1 = item.NomeMarca, @p2 = item.Empreendimento });
            }
        }

        /// <summary>
        /// Converte os dados da ex_cbr para a dimensao de dados
        /// </summary>
        /// <returns></returns>
        private async Task TransformData()
        {
            using (SqlConnection database = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await database.ExecuteAsync(
                @"INSERT INTO DIM_DATA
                    SELECT DISTINCT
                        [Dt Venda] EventDate
                    FROM ex_cbr
                    WHERE [Dt Venda] is not null");
            }
        }

        /// <summary>
        /// Converte os dados do log de navegacao para a tabela de dimensao site
        /// </summary>
        /// <returns></returns>
        private async Task TransformLogNavegacao()
        {
            using (SqlConnection database = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                IEnumerable<Site> DimensionSite = await database.QueryAsync<Site>(
                    @"SELECT    pagina as Id_Pagina,
                                CASE
                                  WHEN Origem IS NULL THEN 'Portal'
                                  ELSE 'Aplicativo' END as Origem,
                                Atividade,
                                count(Pagina) as Acessos
                    FROM [dbo].[log_navegacao] lv
                    GROUP by Pagina, Atividade,
                            CASE when Origem IS NULL THEN 'Portal'
                            ELSE 'Aplicativo' END");

                foreach (Site item in DimensionSite)
                {
                    database.Execute(@"INSERT INTO DIM_SITE VALUES (@p1, @p2, @p3, @p4);", new
                    {
                        @p1 = item.Id_Pagina,
                        @p2 = item.Atividade,
                        @p3 = item.Origem,
                        @p4 = item.Acessos
                    });
                }
            }
        }

        /// <summary>
        /// Converte os dados de posicao financeira para a fato de dimensao financeira
        /// </summary>
        /// <returns></returns>
        private async Task TransformPosicaoFinanceiraFato()
        {
            using (SqlConnection database = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await database.ExecuteAsync(
                @"INSERT INTO FATO_POSICAOFINANCEIRA (SK_CLiENTE, SK_MARCA, SK_DATA, VGV, SaldoDevedor, ValorPago)
                    SELECT
                        a2.SK_CLiENTE,
                        a3.SK_MARCA,
                        a4.SK_DATA,
                        a1.VGV,
                        a1.[Saldo Devedor] SaldoDevedor,
                        a1.[Valor Pago] ValorPago
                    from ex_cbr a1
                    join DIM_CLIENTE a2 on a2.Nome = a1.Cliente
                    join Carteira c on c.obra_cod = a1.Obra
                    join DIM_MARCA a3 on a3.NomeMarca = a1.Marca
                    join DIM_DATA a4 on a4.DATA = a1.[Dt Venda]");
            }
        }
    }
}