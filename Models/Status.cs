namespace PedidoApp.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataHora { get; set; }
    }
}
