namespace Cyrella.ETL.Models.Fato
{
  public class PosicaoFinanceira
  {
    public int? SK_POSICAOFINANCEIRA { get; set; }

    public int? SK_CLiENTE { get; set; }

    public int? SK_DATA { get; set; }

    public int? SK_FATO { get; set; }

    public int? SK_MARCA { get; set; }

    public decimal? ValorPago { get; set; }

    public decimal? SaldoDevedor { get; set; }

    public decimal? VGV { get; set; }
  }
}
