using Microsoft.EntityFrameworkCore;
using PedidoApp.Models; // Certifique-se de que esta linha está presente

namespace PedidoApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
