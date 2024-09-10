using Microsoft.EntityFrameworkCore;
using PedidoApp.Models;

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
