namespace Cyrella.ETL.Models.Dimensao
{
  public class Cliente
  {
    public int? SK_CLiENTE { get; set; }

    public string Obra { get; set; }

    public string Bloco { get; set; }

    public string Unidade { get; set; }

    public bool? Ativo { get; set; }

    public decimal? PercentualPago { get; set; }

    public string Nome { get; set; }

    public string DocumentoCliente { get; set; }
  }
}
