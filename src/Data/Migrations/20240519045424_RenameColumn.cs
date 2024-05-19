using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EQUIPAMENTO_CATEGORIA_CategoriaId",
                table: "EQUIPAMENTO");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "EQUIPAMENTO",
                newName: "CATEGORIA_ID");

            migrationBuilder.RenameIndex(
                name: "IX_EQUIPAMENTO_CategoriaId",
                table: "EQUIPAMENTO",
                newName: "IX_EQUIPAMENTO_CATEGORIA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EQUIPAMENTO_CATEGORIA_CATEGORIA_ID",
                table: "EQUIPAMENTO",
                column: "CATEGORIA_ID",
                principalTable: "CATEGORIA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EQUIPAMENTO_CATEGORIA_CATEGORIA_ID",
                table: "EQUIPAMENTO");

            migrationBuilder.RenameColumn(
                name: "CATEGORIA_ID",
                table: "EQUIPAMENTO",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_EQUIPAMENTO_CATEGORIA_ID",
                table: "EQUIPAMENTO",
                newName: "IX_EQUIPAMENTO_CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EQUIPAMENTO_CATEGORIA_CategoriaId",
                table: "EQUIPAMENTO",
                column: "CategoriaId",
                principalTable: "CATEGORIA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
