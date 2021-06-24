using System;

namespace Cyrella.ETL.Models
{
  public class Coobrigado
  {
    public int Id { get; set; }

    public string Obra { get; set; }

    public string Bloco { get; set; }

    public string Unidade { get; set; }

    public string Nome { get; set; }

    public string CPF_CNPJ { get; set; }

    public decimal PercentualParticipacao { get; set; }

    public bool Principal { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Ativo { get; set; }

    public string CodClienteSap { get; set; }

  }

}

