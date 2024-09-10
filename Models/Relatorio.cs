using System;

namespace PedidoApp.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public string TipoRelatorio { get; set; }
        public DateTime DataGeracao { get; set; }
    }
}
