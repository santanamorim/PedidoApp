namespace PedidoApp.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public string TipoRelatorio { get; set; } = string.Empty;
        public DateTime DataGeracao { get; set; }
    }
}
