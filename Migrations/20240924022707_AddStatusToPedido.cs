using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PedidoApp.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Relatorios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataGeracao",
                value: new DateTime(2024, 9, 23, 22, 27, 7, 291, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Relatorios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataGeracao",
                value: new DateTime(2024, 9, 23, 22, 27, 7, 291, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataHora",
                value: new DateTime(2024, 9, 23, 22, 27, 7, 291, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataHora",
                value: new DateTime(2024, 9, 23, 22, 27, 7, 291, DateTimeKind.Local).AddTicks(6040));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Relatorios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataGeracao",
                value: new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Relatorios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataGeracao",
                value: new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataHora",
                value: new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataHora",
                value: new DateTime(2024, 9, 23, 22, 10, 9, 999, DateTimeKind.Local).AddTicks(1880));
        }
    }
}
