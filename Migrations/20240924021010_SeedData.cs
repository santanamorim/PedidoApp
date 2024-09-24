using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PedidoApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Relatorios",
                columns: new[] { "Id", "DataGeracao", "TipoRelatorio" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1970), "Relatório de Vendas" },
                    { 2, new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1980), "Relatório de Estoque" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "DataHora", "Descricao", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1860), "Pedido em andamento", "Pendente" },
                    { 2, new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1880), "Pedido finalizado", "Concluído" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Relatorios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Relatorios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
