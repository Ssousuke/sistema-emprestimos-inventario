using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_CRIACAO",
                table: "EQUIPAMENTO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(8949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ATUALIZACAO",
                table: "EQUIPAMENTO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_CRIACAO",
                table: "CATEGORIA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(6874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ATUALIZACAO",
                table: "CATEGORIA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(7319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_CRIACAO",
                table: "EQUIPAMENTO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ATUALIZACAO",
                table: "EQUIPAMENTO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_CRIACAO",
                table: "CATEGORIA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_ATUALIZACAO",
                table: "CATEGORIA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 19, 15, 12, 18, 1, DateTimeKind.Local).AddTicks(7319));
        }
    }
}
