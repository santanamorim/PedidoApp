using System;

namespace PedidoApp.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }
        public string EnderecoEntrega { get; set; }
        public DateTime Prazo { get; set; }
        public Status Status { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
