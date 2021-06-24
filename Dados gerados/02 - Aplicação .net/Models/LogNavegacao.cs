using System;

namespace Cyrella.ETL.Models
{
  public class LogNavegacao
  {
    public long Id { get; set; }

    public string DocumentoCliente { get; set; }

    public DateTime DataEvento { get; set; }

    public int TipoEvento { get; set; }

    public int TipoAcesso { get; set; }

    public Guid? IdAtendente { get; set; }

    public string Pagina { get; set; }

    public string Atividade { get; set; }

    public string LogErro { get; set; }

    public int? Origem { get; set; }
  }

}

