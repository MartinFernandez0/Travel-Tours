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
                name: "pfClientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfClientes", x => x.ID);
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
                    ClienteID = table.Column<int>(type: "int", nullable: false),
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
                    ClienteID = table.Column<int>(type: "int", nullable: false),
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
                    { 1, "Tour guiado a la Torre Eiffel", new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8459), 1, "Visita a la Torre Eiffel" },
                    { 2, "Crucero por el río Hudson", new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8461), 2, "Paseo en barco por el Hudson" }
                });

            migrationBuilder.InsertData(
                table: "pfAdministradores",
                columns: new[] { "ID", "Apellido", "Email", "FechaRegistro", "Nombre", "Telefono" },
                values: new object[] { 1, "Fernandez", "martin_fernandez@example.com", new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8187), "Martin", "3498479331" });

            migrationBuilder.InsertData(
                table: "pfClientes",
                columns: new[] { "ID", "Apellido", "Documento", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Apellido1", "123456789", "cliente1@example.com", "Cliente1", "1234567890" },
                    { 2, "Apellido2", "987654321", "cliente2@example.com", "Cliente2", "0987654321" },
                    { 3, "Apellido3", "456789123", "cliente3@example.com", "Cliente3", "4567891230" },
                    { 4, "Apellido4", "321654987", "cliente4@example.com", "Cliente4", "3216549870" },
                    { 5, "Apellido5", "789123456", "cliente5@example.com", "Cliente5", "7891234560" }
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
                    { 1, 0, "Hotel en París", new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8497), 1, 100.00m },
                    { 2, 1, "Comida en Nueva York", new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8499), 2, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "pfItinerarios",
                columns: new[] { "ID", "Descripcion", "Destino", "FechaRegreso", "FechaSalida" },
                values: new object[,]
                {
                    { 1, "Viaje a París", "París", new DateTime(2024, 10, 9, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 10, 2, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8522) },
                    { 2, "Viaje a Nueva York", "Nueva York", new DateTime(2024, 10, 23, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 10, 16, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8535) }
                });

            migrationBuilder.InsertData(
                table: "pfReservas",
                columns: new[] { "ID", "AdministradorID", "ClienteID", "EstadoReservaEnum", "FechaReserva", "ItinerarioID" },
                values: new object[] { 1, 0, 1, 0, new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8558), 1 });

            migrationBuilder.InsertData(
                table: "pfTransacciones",
                columns: new[] { "ID", "AdministradorID", "ClienteID", "ConfirmacionPagoEnum", "Fecha", "FormaDePagoEnum", "ItinerarioID", "Monto" },
                values: new object[,]
                {
                    { 1, 0, 1, 1, new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8581), 1, 1, 1500.00m },
                    { 2, 0, 2, 2, new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8584), 2, 2, 2000.00m },
                    { 3, 0, 3, 3, new DateTime(2024, 9, 25, 17, 20, 19, 378, DateTimeKind.Local).AddTicks(8586), 3, 1, 500.00m }
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
                name: "pfClientes");

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
