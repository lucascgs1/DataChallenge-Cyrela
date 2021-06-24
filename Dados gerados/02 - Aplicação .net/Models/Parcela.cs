using System;

namespace Cyrella.ETL.Models
{
  public class Parcela
  {
    public string Obra { get; set; }

    public string Bloco { get; set; }

    public string Unidade { get; set; }

    public string Id_Contrato_Vencimento { get; set; }

    public string Contrato { get; set; }

    public DateTime DataVencimento { get; set; }

    public decimal ValorPrestacao { get; set; }

    public decimal? Principal { get; set; }

    public decimal? JurosTP { get; set; }

    public decimal? Variacoes { get; set; }

    public decimal? Seguros { get; set; }

    public decimal? Descontos { get; set; }

    public decimal? Multa { get; set; }

    public decimal? JurosMora { get; set; }

    public decimal? ProRataIndice { get; set; }

    public decimal? ProRataContrato { get; set; }

    public decimal? ValorPresente { get; set; }

    public string IndiceReajuste { get; set; }

    public string SituacaoParcela { get; set; }

    public string BoletoJM { get; set; }

    public DateTime? VencimentoJM { get; set; }

    public string Periodicidade { get; set; }

    public string TipoContrato { get; set; }

    public string TipoEmprestimo { get; set; }

    public string TipoBloqueio { get; set; }

    public bool CRM_ProcessamentoPendente { get; set; }

    public string CRM_Operacao { get; set; }

    public Guid? CRM_ParcelaId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public string GeradoPor { get; set; }

    public int? IDRENEG { get; set; }

    public DateTime? DataRenegociacao { get; set; }

    public decimal? ValorAbono { get; set; }

    public decimal? ValorAcrescimo { get; set; }

    public decimal? VLRABONOMULTA { get; set; }

    public decimal? VLRABONOJUROS { get; set; }

    public decimal? VLRABONOPRORATA { get; set; }

    public decimal? TX_JUROS { get; set; }

    public decimal? TX_ENCARGOS { get; set; }

    public string MotivoRenegociacao { get; set; }
  }

}

