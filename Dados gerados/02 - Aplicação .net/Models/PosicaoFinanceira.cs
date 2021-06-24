using System;

namespace Cyrella.ETL.Models
{
  public class PosicaoFinanceira
  {
    public string Obra { get; set; }

    public string Bloco { get; set; }

    public string Unidade { get; set; }

    public string Empresa { get; set; }

    public string SituacaoUnidade { get; set; }

    public DateTime? DataVenda { get; set; }

    public decimal? ValorVenda { get; set; }

    public DateTime? DataLiberacaoChaves { get; set; }

    public int? FormaPagamento { get; set; }

    public string FaseIncorporacao { get; set; }

    public DateTime? DataCessao { get; set; }

    public DateTime? DataDesembolso { get; set; }

    public DateTime? DataEntregaInicial { get; set; }

    public DateTime? DataHabiteSe { get; set; }

    public string StatusDistrato { get; set; }

    public DateTime? DataChaves { get; set; }

    public string IndicePreChaves { get; set; }

    public string IndicePosChaves { get; set; }

    public string DebitoAutomatico { get; set; }

    public decimal SaldoDevedor { get; set; }

    public int DiasAtraso { get; set; }

    public decimal ValorAtraso { get; set; }

    public decimal TotalAtraso { get; set; }

    public bool CRM_ProcessamentoPendente { get; set; }

    public string CRM_Operacao { get; set; }

    public Guid? CRM_PosicaoFinanceiraId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public DateTime? DataPrevisaoEntrega { get; set; }

    public decimal? ValorPago { get; set; }

    public decimal? ValorPagoAtualizado { get; set; }

    public string TipoPagamento { get; set; }

    public DateTime? DataQuitacao { get; set; }

    public decimal? ValorQuitacao { get; set; }

    public string LR_TipoContrato { get; set; }

    public decimal? LR_Saldo { get; set; }

    public DateTime? LR_DataVencimento { get; set; }

    public string LR_Codigo { get; set; }

    public DateTime? LR_DataRenegociacao { get; set; }

    public decimal? PCVF_SaldoDevedor { get; set; }

    public decimal? PCVF_TotalAtraso { get; set; }

    public decimal? PCVU_SaldoDevedor { get; set; }

    public decimal? PCVU_TotalAtraso { get; set; }

    public decimal? PCVP_SaldoDevedor { get; set; }

    public decimal? PCVP_TotalAtraso { get; set; }

    public decimal? DEC_SaldoDevedor { get; set; }

    public decimal? DEC_TotalAtraso { get; set; }

    public decimal? MOD_SaldoDevedor { get; set; }

    public decimal? MOD_TotalAtraso { get; set; }

    public decimal? LIG_SaldoDevedor { get; set; }

    public decimal? LIG_TotalAtraso { get; set; }

    public decimal? TCS_SaldoDevedor { get; set; }

    public decimal? TCS_TotalAtraso { get; set; }

    public decimal? LOT_SaldoDevedor { get; set; }

    public decimal? LOT_TotalAtraso { get; set; }

    public bool CRM_ProcessamentoPendenteRepasse { get; set; }

    public decimal? ValorTotalReceberObras { get; set; }

    public decimal? ValorParcelaChaves { get; set; }

    public decimal? ValorTotalPosObra { get; set; }

    public DateTime? DataUltimaPrestacaoPaga { get; set; }

    public DateTime? DataUltimaAlteracao { get; set; }
  }

}

