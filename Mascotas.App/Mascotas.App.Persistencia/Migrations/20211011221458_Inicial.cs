using Microsoft.EntityFrameworkCore.Migrations;

namespace Mascotas.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estadoMascota",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrecuenciaRespiratoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrecuenciaCardiaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoDeAnimo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadoMascota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "listaMascota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDueno = table.Column<int>(type: "int", nullable: false),
                    IdMascotas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaMascota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "listaMedicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMedicos = table.Column<int>(type: "int", nullable: false),
                    IdentificacionMedico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaMedicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListaVisitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisitas = table.Column<int>(type: "int", nullable: false),
                    IdentificacionMedico = table.Column<int>(type: "int", nullable: false),
                    NombreMascota = table.Column<int>(type: "int", nullable: false),
                    IdDueno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaVisitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorDeOjos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorDePiel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatura = table.Column<float>(type: "real", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoAnimal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitaVeterinaria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoMascotaId = table.Column<long>(type: "bigint", nullable: true),
                    IdVeterinario = table.Column<int>(type: "int", nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitaVeterinaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitaVeterinaria_estadoMascota_EstadoMascotaId",
                        column: x => x.EstadoMascotaId,
                        principalTable: "estadoMascota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListaMascotasId = table.Column<int>(type: "int", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_listaMascota_ListaMascotasId",
                        column: x => x.ListaMascotasId,
                        principalTable: "listaMascota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudDeVisita",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificacionDuenoMascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    listaMascotaId = table.Column<int>(type: "int", nullable: true),
                    TipoAnimal = table.Column<int>(type: "int", nullable: false),
                    ListaMedicosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudDeVisita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudDeVisita_listaMascota_listaMascotaId",
                        column: x => x.listaMascotaId,
                        principalTable: "listaMascota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudDeVisita_listaMedicos_ListaMedicosId",
                        column: x => x.ListaMedicosId,
                        principalTable: "listaMedicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ListaMascotasId",
                table: "Persona",
                column: "ListaMascotasId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudDeVisita_listaMascotaId",
                table: "SolicitudDeVisita",
                column: "listaMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudDeVisita_ListaMedicosId",
                table: "SolicitudDeVisita",
                column: "ListaMedicosId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitaVeterinaria_EstadoMascotaId",
                table: "VisitaVeterinaria",
                column: "EstadoMascotaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "ListaVisitas");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "SolicitudDeVisita");

            migrationBuilder.DropTable(
                name: "VisitaVeterinaria");

            migrationBuilder.DropTable(
                name: "listaMascota");

            migrationBuilder.DropTable(
                name: "listaMedicos");

            migrationBuilder.DropTable(
                name: "estadoMascota");
        }
    }
}
