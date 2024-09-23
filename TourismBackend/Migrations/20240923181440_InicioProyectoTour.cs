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
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Notas = table.Column<string>(type: "longtext", nullable: false)
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
                name: "pfEmpleados",
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
                    Rol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaContratacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Notas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfEmpleados", x => x.ID);
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
                    ClienteID = table.Column<int>(type: "int", nullable: false),
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
                    ClienteID = table.Column<int>(type: "int", nullable: false),
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
                    { 1, "Tour guiado a la Torre Eiffel", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6906), 1, "Visita a la Torre Eiffel" },
                    { 2, "Crucero por el río Hudson", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6909), 2, "Paseo en barco por el Hudson" }
                });

            migrationBuilder.InsertData(
                table: "pfAdministradores",
                columns: new[] { "ID", "Apellido", "Email", "FechaRegistro", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Rodríguez", "carlos.rodriguez@example.com", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6853), "Carlos", "12345678" },
                    { 2, "Fernández", "maria.fernandez@example.com", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6856), "María", "12345678" }
                });

            migrationBuilder.InsertData(
                table: "pfClientes",
                columns: new[] { "ID", "Apellido", "Email", "FechaRegistro", "Nombre", "Notas", "Telefono" },
                values: new object[,]
                {
                    { 1, "Pérez", "juan.perez@example.com", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6604), "Juan", "Cliente frecuente", "123456789" },
                    { 2, "García", "ana.garcia@example.com", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6617), "Ana", "Interesada en viajes a Europa", "987654321" }
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
                table: "pfEmpleados",
                columns: new[] { "ID", "Apellido", "Email", "FechaContratacion", "Nombre", "Notas", "Rol", "Telefono" },
                values: new object[,]
                {
                    { 1, "Martínez", "luis.martinez@example.com", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6822), "Luis", "Empleado con más ventas", "Agente de viajes", "123123123" },
                    { 2, "Lopez", "laura.lopez@example.com", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6824), "Laura", "Empleado con más reservas", "Agente de viajes", "321321321" }
                });

            migrationBuilder.InsertData(
                table: "pfGastos",
                columns: new[] { "ID", "CategoriaGastoEnum", "Descripcion", "Fecha", "ItinerarioID", "Monto" },
                values: new object[,]
                {
                    { 1, 0, "Hotel en París", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6937), 1, 100.00m },
                    { 2, 1, "Comida en Nueva York", new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6940), 2, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "pfItinerarios",
                columns: new[] { "ID", "Descripcion", "Destino", "FechaRegreso", "FechaSalida" },
                values: new object[,]
                {
                    { 1, "Viaje a París", "París", new DateTime(2024, 10, 7, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 9, 30, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6966) },
                    { 2, "Viaje a Nueva York", "Nueva York", new DateTime(2024, 10, 21, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 10, 14, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(6976) }
                });

            migrationBuilder.InsertData(
                table: "pfReservas",
                columns: new[] { "ID", "ClienteID", "EstadoReservaEnum", "FechaReserva", "ItinerarioID" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(7003), 1 },
                    { 2, 2, 1, new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(7005), 2 }
                });

            migrationBuilder.InsertData(
                table: "pfTransacciones",
                columns: new[] { "ID", "ClienteID", "ConfirmacionPagoEnum", "Fecha", "FormaDePagoEnum", "ItinerarioID", "Monto" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(7031), 1, 1, 1500.00m },
                    { 2, 2, 2, new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(7033), 2, 2, 2000.00m },
                    { 3, 1, 3, new DateTime(2024, 9, 23, 15, 14, 36, 201, DateTimeKind.Local).AddTicks(7036), 3, 1, 500.00m }
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
                name: "pfEmpleados");

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
