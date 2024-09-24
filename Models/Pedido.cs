using System;

namespace PedidoApp.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public string Descricao { get; set; } = string.Empty;
        public string EnderecoEntrega { get; set; } = string.Empty;
        public DateTime Prazo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();

        public int StatusId { get; set; }
        public Status Status { get; set; } = new Status();
    }
}
