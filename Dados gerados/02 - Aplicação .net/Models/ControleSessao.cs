using System;

namespace Cyrella.ETL.Models
{
  public class ControleSessao
  {
    public long Id { get; set; }

    public DateTime DataAcesso { get; set; }

    public string Hash { get; set; }

    public DateTime DataExpiracao { get; set; }

    public string Cliente { get; set; }

    public int TipoAcesso { get; set; }

    public string LoginAtendente { get; set; }

    public int? TipoSessao { get; set; }

    public int? Origem { get; set; }

  }

}

