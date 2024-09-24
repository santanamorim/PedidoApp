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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Tipo = "Pendente", Descricao = "Pedido em andamento", DataHora = DateTime.Now },
                new Status { Id = 2, Tipo = "Concluído", Descricao = "Pedido finalizado", DataHora = DateTime.Now }
            );

            modelBuilder.Entity<Relatorio>().HasData(
                new Relatorio { Id = 1, TipoRelatorio = "Relatório de Vendas", DataGeracao = DateTime.Now },
                new Relatorio { Id = 2, TipoRelatorio = "Relatório de Estoque", DataGeracao = DateTime.Now }
            );
        }
    }
}

