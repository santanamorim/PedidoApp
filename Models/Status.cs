using System;

namespace PedidoApp.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
    }
}
