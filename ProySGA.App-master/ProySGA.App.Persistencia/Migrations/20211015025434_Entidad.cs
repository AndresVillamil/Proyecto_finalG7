using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProySGA.App.Persistencia.Migrations
{
    public partial class Entidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profesion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salario = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Grados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Periodos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    padreid = table.Column<int>(type: "int", nullable: true),
                    madreid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_madreid",
                        column: x => x.madreid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_padreid",
                        column: x => x.padreid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    directorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Grupos_Docentes_directorid",
                        column: x => x.directorid,
                        principalTable: "Docentes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaid = table.Column<int>(type: "int", nullable: true),
                    gradoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Area_areaid",
                        column: x => x.areaid,
                        principalTable: "Area",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Grados_gradoid",
                        column: x => x.gradoid,
                        principalTable: "Grados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Acudientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    acudidoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Acudientes_Personas_acudidoid",
                        column: x => x.acudidoid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    creador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estudianteid = table.Column<int>(type: "int", nullable: true),
                    grupoid = table.Column<int>(type: "int", nullable: true),
                    gradoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Matriculas_Grados_gradoid",
                        column: x => x.gradoid,
                        principalTable: "Grados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Grupos_grupoid",
                        column: x => x.grupoid,
                        principalTable: "Grupos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Personas_estudianteid",
                        column: x => x.estudianteid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AsignaturasGrupo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asignaturaid = table.Column<int>(type: "int", nullable: true),
                    docenteid = table.Column<int>(type: "int", nullable: true),
                    grupoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignaturasGrupo", x => x.id);
                    table.ForeignKey(
                        name: "FK_AsignaturasGrupo_Asignaturas_asignaturaid",
                        column: x => x.asignaturaid,
                        principalTable: "Asignaturas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignaturasGrupo_Docentes_docenteid",
                        column: x => x.docenteid,
                        principalTable: "Docentes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignaturasGrupo_Grupos_grupoid",
                        column: x => x.grupoid,
                        principalTable: "Grupos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asignaturaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencias", x => x.id);
                    table.ForeignKey(
                        name: "FK_Competencias_AsignaturasGrupo_asignaturaid",
                        column: x => x.asignaturaid,
                        principalTable: "AsignaturasGrupo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asitencia = table.Column<bool>(type: "bit", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    competenciaid = table.Column<int>(type: "int", nullable: true),
                    periodoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.id);
                    table.ForeignKey(
                        name: "FK_Actividades_Competencias_competenciaid",
                        column: x => x.competenciaid,
                        principalTable: "Competencias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actividades_Periodos_periodoid",
                        column: x => x.periodoid,
                        principalTable: "Periodos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_competenciaid",
                table: "Actividades",
                column: "competenciaid");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_periodoid",
                table: "Actividades",
                column: "periodoid");

            migrationBuilder.CreateIndex(
                name: "IX_Acudientes_acudidoid",
                table: "Acudientes",
                column: "acudidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_areaid",
                table: "Asignaturas",
                column: "areaid");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_gradoid",
                table: "Asignaturas",
                column: "gradoid");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturasGrupo_asignaturaid",
                table: "AsignaturasGrupo",
                column: "asignaturaid");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturasGrupo_docenteid",
                table: "AsignaturasGrupo",
                column: "docenteid");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturasGrupo_grupoid",
                table: "AsignaturasGrupo",
                column: "grupoid");

            migrationBuilder.CreateIndex(
                name: "IX_Competencias_asignaturaid",
                table: "Competencias",
                column: "asignaturaid");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_directorid",
                table: "Grupos",
                column: "directorid");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_estudianteid",
                table: "Matriculas",
                column: "estudianteid");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_gradoid",
                table: "Matriculas",
                column: "gradoid");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_grupoid",
                table: "Matriculas",
                column: "grupoid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_madreid",
                table: "Personas",
                column: "madreid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_padreid",
                table: "Personas",
                column: "padreid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Acudientes");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Competencias");

            migrationBuilder.DropTable(
                name: "Periodos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "AsignaturasGrupo");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Grados");

            migrationBuilder.DropTable(
                name: "Docentes");
        }
    }
}
