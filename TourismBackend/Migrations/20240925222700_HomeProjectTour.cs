using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourismBackend.Migrations
{
    /// <inheritdoc />
    public partial class HomeProjectTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfActivities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItineraryID = table.Column<int>(type: "int", nullable: false),
                    ActivityName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfActivities", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfAdministrators",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfAdministrators", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfClients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Document = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfClients", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfDestinations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfDestinations", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfExpenses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItineraryID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpenseCategory = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfExpenses", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfItineraries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Destination = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartureDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfItineraries", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfReservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdministratorID = table.Column<int>(type: "int", nullable: false),
                    ItineraryID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfReservations", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pfTransactions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdministratorID = table.Column<int>(type: "int", nullable: false),
                    ItineraryID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentConfirmation = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfTransactions", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "pfActivities",
                columns: new[] { "ID", "ActivityName", "Date", "Description", "ItineraryID" },
                values: new object[,]
                {
                    { 1, "Visit the Eiffel Tower", new DateTime(2024, 9, 25, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9899), "Guided tour of the Eiffel Tower", 1 },
                    { 2, "Boat ride on the Hudson", new DateTime(2024, 9, 25, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9902), "Cruise on the Hudson River", 2 }
                });

            migrationBuilder.InsertData(
                table: "pfAdministrators",
                columns: new[] { "ID", "Email", "LastName", "Name", "Phone", "RegistrationDate" },
                values: new object[] { 1, "martin_fernandez@example.com", "Fernandez", "Martin", "3498479331", new DateTime(2024, 9, 25, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.InsertData(
                table: "pfClients",
                columns: new[] { "ID", "Document", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123456789", "client1@example.com", "Client1", "LastName1", "1234567890" },
                    { 2, "987654321", "client2@example.com", "Client2", "LastName2", "0987654321" },
                    { 3, "456789123", "client3@example.com", "Client3", "LastName3", "4567891230" },
                    { 4, "321654987", "client4@example.com", "Client4", "LastName4", "3216549870" },
                    { 5, "789123456", "client5@example.com", "Client5", "LastName5", "7891234560" }
                });

            migrationBuilder.InsertData(
                table: "pfDestinations",
                columns: new[] { "ID", "Country", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "France", "City of love", "Paris" },
                    { 2, "United States", "The Big Apple", "New York" }
                });

            migrationBuilder.InsertData(
                table: "pfExpenses",
                columns: new[] { "ID", "Amount", "Date", "Description", "ExpenseCategory", "ItineraryID" },
                values: new object[,]
                {
                    { 1, 100.00m, new DateTime(2024, 9, 25, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9965), "Hotel in Paris", 0, 1 },
                    { 2, 50.00m, new DateTime(2024, 9, 25, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9968), "Food in New York", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "pfItineraries",
                columns: new[] { "ID", "DepartureDate", "Description", "Destination", "ReturnDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 2, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9993), "Trip to Paris", "Paris", new DateTime(2024, 10, 9, 19, 26, 56, 103, DateTimeKind.Local).AddTicks(9998) },
                    { 2, new DateTime(2024, 10, 16, 19, 26, 56, 104, DateTimeKind.Local), "Trip to New York", "New York", new DateTime(2024, 10, 23, 19, 26, 56, 104, DateTimeKind.Local).AddTicks(1) }
                });

            migrationBuilder.InsertData(
                table: "pfReservations",
                columns: new[] { "ID", "AdministratorID", "ClientID", "ItineraryID", "ReservationDate", "ReservationStatus" },
                values: new object[] { 1, 0, 1, 1, new DateTime(2024, 9, 25, 19, 26, 56, 104, DateTimeKind.Local).AddTicks(31), 0 });

            migrationBuilder.InsertData(
                table: "pfTransactions",
                columns: new[] { "ID", "AdministratorID", "Amount", "ClientID", "Date", "ItineraryID", "PaymentConfirmation", "PaymentMethod" },
                values: new object[,]
                {
                    { 1, 0, 1500.00m, 1, new DateTime(2024, 9, 25, 19, 26, 56, 104, DateTimeKind.Local).AddTicks(54), 1, 1, 1 },
                    { 2, 0, 2000.00m, 2, new DateTime(2024, 9, 25, 19, 26, 56, 104, DateTimeKind.Local).AddTicks(141), 2, 2, 2 },
                    { 3, 0, 500.00m, 3, new DateTime(2024, 9, 25, 19, 26, 56, 104, DateTimeKind.Local).AddTicks(144), 1, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pfActivities");

            migrationBuilder.DropTable(
                name: "pfAdministrators");

            migrationBuilder.DropTable(
                name: "pfClients");

            migrationBuilder.DropTable(
                name: "pfDestinations");

            migrationBuilder.DropTable(
                name: "pfExpenses");

            migrationBuilder.DropTable(
                name: "pfItineraries");

            migrationBuilder.DropTable(
                name: "pfReservations");

            migrationBuilder.DropTable(
                name: "pfTransactions");
        }
    }
}
