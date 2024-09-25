using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class InicioProyectoTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfActividades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItinerarioID = table.Column<int>(type: "int", nullable: false),
                    NombreActividad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfActividades", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfAdministradores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfAdministradores", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfDestinos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfDestinos", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfGastos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItinerarioID = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CategoriaGastoEnum = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfGastos", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfItinerarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Destino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaSalida = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaRegreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfItinerarios", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfReservas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdministradorID = table.Column<int>(type: "int", nullable: false),
                    ItinerarioID = table.Column<int>(type: "int", nullable: false),
                    EstadoReservaEnum = table.Column<int>(type: "int", nullable: false),
                    FechaReserva = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfReservas", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfTransacciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdministradorID = table.Column<int>(type: "int", nullable: false),
                    ItinerarioID = table.Column<int>(type: "int", nullable: false),
                    FormaDePagoEnum = table.Column<int>(type: "int", nullable: false),
                    ConfirmacionPagoEnum = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfTransacciones", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "pfActividades",
                columns: new[] { "ID", "Descripcion", "Fecha", "ItinerarioID", "NombreActividad" },
                values: new object[,]
                {
                    { 1, "Tour guiado a la Torre Eiffel", new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5641), 1, "Visita a la Torre Eiffel" },
                    { 2, "Crucero por el río Hudson", new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5643), 2, "Paseo en barco por el Hudson" }
                });

            migrationBuilder.InsertData(
                table: "pfAdministradores",
                columns: new[] { "ID", "Apellido", "Email", "FechaRegistro", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Rodríguez", "carlos.rodriguez@example.com", new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5484), "Carlos", "12345678" },
                    { 2, "Fernández", "maria.fernandez@example.com", new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5497), "María", "12345678" }
                });

            migrationBuilder.InsertData(
                table: "pfDestinos",
                columns: new[] { "ID", "Descripcion", "Nombre", "Pais" },
                values: new object[,]
                {
                    { 1, "Ciudad del amor", "París", "Francia" },
                    { 2, "La gran manzana", "Nueva York", "Estados Unidos" }
                });

            migrationBuilder.InsertData(
                table: "pfGastos",
                columns: new[] { "ID", "CategoriaGastoEnum", "Descripcion", "Fecha", "ItinerarioID", "Monto" },
                values: new object[,]
                {
                    { 1, 0, "Hotel en París", new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5667), 1, 100.00m },
                    { 2, 1, "Comida en Nueva York", new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5785), 2, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "pfItinerarios",
                columns: new[] { "ID", "Descripcion", "Destino", "FechaRegreso", "FechaSalida" },
                values: new object[,]
                {
                    { 1, "Viaje a París", "París", new DateTime(2024, 10, 9, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5826), new DateTime(2024, 10, 2, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5819) },
                    { 2, "Viaje a Nueva York", "Nueva York", new DateTime(2024, 10, 23, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5828), new DateTime(2024, 10, 16, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5827) }
                });

            migrationBuilder.InsertData(
                table: "pfReservas",
                columns: new[] { "ID", "AdministradorID", "EstadoReservaEnum", "FechaReserva", "ItinerarioID" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5850), 1 },
                    { 2, 2, 1, new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5852), 2 }
                });

            migrationBuilder.InsertData(
                table: "pfTransacciones",
                columns: new[] { "ID", "AdministradorID", "ConfirmacionPagoEnum", "Fecha", "FormaDePagoEnum", "ItinerarioID", "Monto" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5874), 1, 1, 1500.00m },
                    { 2, 2, 2, new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5877), 2, 2, 2000.00m },
                    { 3, 1, 3, new DateTime(2024, 9, 25, 16, 46, 16, 552, DateTimeKind.Local).AddTicks(5879), 3, 1, 500.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pfActividades");

            migrationBuilder.DropTable(
                name: "pfAdministradores");

            migrationBuilder.DropTable(
                name: "pfDestinos");

            migrationBuilder.DropTable(
                name: "pfGastos");

            migrationBuilder.DropTable(
                name: "pfItinerarios");

            migrationBuilder.DropTable(
                name: "pfReservas");

            migrationBuilder.DropTable(
                name: "pfTransacciones");
        }
    }
}
