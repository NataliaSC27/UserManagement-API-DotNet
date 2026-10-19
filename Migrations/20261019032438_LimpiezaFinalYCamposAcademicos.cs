using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosApi.Migrations
{
    /// <inheritdoc />
    public partial class LimpiezaFinalYCamposAcademicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Usuarios",
                newName: "Semestre");

            migrationBuilder.AddColumn<string>(
                name: "Universidad",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Universidad",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Semestre",
                table: "Usuarios",
                newName: "RolId");

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
