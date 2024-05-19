using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EQUIPAMENTO",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "EQUIPAMENTO",
                newName: "DATA_CRIACAO");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "EQUIPAMENTO",
                newName: "DATA_ATUALIZACAO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CATEGORIA",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CATEGORIA",
                newName: "DATA_CRIACAO");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "CATEGORIA",
                newName: "DATA_ATUALIZACAO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "EQUIPAMENTO",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DATA_CRIACAO",
                table: "EQUIPAMENTO",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DATA_ATUALIZACAO",
                table: "EQUIPAMENTO",
                newName: "DataAtualizacao");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CATEGORIA",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DATA_CRIACAO",
                table: "CATEGORIA",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DATA_ATUALIZACAO",
                table: "CATEGORIA",
                newName: "DataAtualizacao");
        }
    }
}
