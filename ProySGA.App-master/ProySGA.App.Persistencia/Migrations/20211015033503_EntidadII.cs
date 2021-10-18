using Microsoft.EntityFrameworkCore.Migrations;

namespace ProySGA.App.Persistencia.Migrations
{
    public partial class EntidadII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignaturasGrupo_Docentes_docenteid",
                table: "AsignaturasGrupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Docentes_directorid",
                table: "Grupos");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.AddColumn<string>(
                name: "profesion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "salario",
                table: "Personas",
                type: "float",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignaturasGrupo_Personas_docenteid",
                table: "AsignaturasGrupo",
                column: "docenteid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Personas_directorid",
                table: "Grupos",
                column: "directorid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignaturasGrupo_Personas_docenteid",
                table: "AsignaturasGrupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Personas_directorid",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "profesion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "salario",
                table: "Personas");

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profesion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salario = table.Column<double>(type: "float", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AsignaturasGrupo_Docentes_docenteid",
                table: "AsignaturasGrupo",
                column: "docenteid",
                principalTable: "Docentes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Docentes_directorid",
                table: "Grupos",
                column: "directorid",
                principalTable: "Docentes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
