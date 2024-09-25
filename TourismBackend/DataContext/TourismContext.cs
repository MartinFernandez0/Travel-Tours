using Microsoft.EntityFrameworkCore;
using TourismServices.Models;
using TourismServices.Enums;


namespace TourismBackend.DataContext
{
    public partial class TourismContext : DbContext
    {
        public TourismContext()
        {
        }
        public TourismContext(DbContextOptions<TourismContext> options) : base(options)
        {
        }

        // DbSets for your models in the specified order
        public DbSet<pfActivity> pfActivities { get; set; }
        public DbSet<pfAdministrator> pfAdministrators { get; set; }
        public DbSet<pfDestination> pfDestinations { get; set; }
        public DbSet<pfExpense> pfExpenses { get; set; }
        public DbSet<pfItinerary> pfItineraries { get; set; }
        public DbSet<pfReservation> pfReservations { get; set; }
        public DbSet<pfTransaction> pfTransactions { get; set; }
        public DbSet<pfClient> pfClients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

            optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for pfAdministrators
            modelBuilder.Entity<pfAdministrator>().HasData(
                new pfAdministrator
                {
                    ID = 1,
                    Name = "Martin",
                    LastName = "Fernandez",
                    Email = "martin_fernandez@example.com",
                    Phone = "3498479331",
                    RegistrationDate = DateTime.Now
                }
            );

            // Seed data for pfDestinations
            modelBuilder.Entity<pfDestination>().HasData(
                new pfDestination
                {
                    ID = 1,
                    Name = "Paris",
                    Description = "City of love",
                    Country = "France"

                },
                new pfDestination
                {
                    ID = 2,
                    Name = "New York",
                    Description = "The Big Apple",
                    Country = "United States"
                }
            );

            // Seed data for pfActivities
            modelBuilder.Entity<pfActivity>().HasData(
                new pfActivity
                {
                    ID = 1,
                    ActivityName = "Visit the Eiffel Tower",
                    Description = "Guided tour of the Eiffel Tower",
                    Date = DateTime.Now,
                    ItineraryID = 1
                },
                new pfActivity
                {
                    ID = 2,
                    ActivityName = "Boat ride on the Hudson",
                    Description = "Cruise on the Hudson River",
                    Date = DateTime.Now,
                    ItineraryID = 2
                }
            );

            // Seed data for pfExpenses
            modelBuilder.Entity<pfExpense>().HasData(
                new pfExpense
                {
                    ID = 1,
                    Amount = 100.00m,
                    ExpenseCategory = ExpenseCategoryEnum.Accommodation,
                    Description = "Hotel in Paris",
                    Date = DateTime.Now,
                    ItineraryID = 1
                },
                new pfExpense
                {
                    ID = 2,
                    Amount = 50.00m,
                    ExpenseCategory = ExpenseCategoryEnum.Food,
                    Description = "Food in New York",
                    Date = DateTime.Now,
                    ItineraryID = 2
                }
            );

            // Seed data for pfItineraries
            modelBuilder.Entity<pfItinerary>().HasData(
                new pfItinerary
                {
                    ID = 1,
                    Destination = "Paris",
                    DepartureDate = DateTime.Now.AddDays(7),
                    ReturnDate = DateTime.Now.AddDays(14),
                    Description = "Trip to Paris"
                },
                new pfItinerary
                {
                    ID = 2,
                    Destination = "New York",
                    DepartureDate = DateTime.Now.AddDays(21),
                    ReturnDate = DateTime.Now.AddDays(28),
                    Description = "Trip to New York"
                }
            );

            // Seed data for pfReservations
            modelBuilder.Entity<pfReservation>().HasData(
                new pfReservation
                {
                    ID = 1,
                    ClientID = 1,
                    ItineraryID = 1,
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Confirmed
                }
            );

            // Seed data for pfTransactions
            modelBuilder.Entity<pfTransaction>().HasData(
                new pfTransaction
                {
                    ID = 1,
                    Amount = 1500.00m,
                    Date = DateTime.Now,
                    ClientID = 1,
                    ItineraryID = 1,
                    PaymentConfirmation = PaymentConfirmationEnum.Confirmed,
                    PaymentMethod = PaymentMethodEnum.CreditCard
                },
                new pfTransaction
                {
                    ID = 2,
                    Amount = 2000.00m,
                    Date = DateTime.Now,
                    ClientID = 2,
                    ItineraryID = 2,
                    PaymentConfirmation = PaymentConfirmationEnum.Rejected,
                    PaymentMethod = PaymentMethodEnum.DebitCard
                },
                new pfTransaction
                {
                    ID = 3,
                    Amount = 500.00m,
                    Date = DateTime.Now,
                    ClientID = 3,
                    ItineraryID = 1,
                    PaymentConfirmation = PaymentConfirmationEnum.Refunded,
                    PaymentMethod = PaymentMethodEnum.BankTransfer
                }
            );

            // Seed data for pfClients
            modelBuilder.Entity<pfClient>().HasData(
                new pfClient
                {
                    ID = 1,
                    FirstName = "Client1",
                    LastName = "LastName1",
                    Document = "123456789",
                    Email = "client1@example.com",
                    PhoneNumber = "1234567890"
                },
                new pfClient
                {
                    ID = 2,
                    FirstName = "Client2",
                    LastName = "LastName2",
                    Document = "987654321",
                    Email = "client2@example.com",
                    PhoneNumber = "0987654321"
                },
                new pfClient
                {
                    ID = 3,
                    FirstName = "Client3",
                    LastName = "LastName3",
                    Document = "456789123",
                    Email = "client3@example.com",
                    PhoneNumber = "4567891230"
                },
                new pfClient
                {
                    ID = 4,
                    FirstName = "Client4",
                    LastName = "LastName4",
                    Document = "321654987",
                    Email = "client4@example.com",
                    PhoneNumber = "3216549870"
                },
                new pfClient
                {
                    ID = 5,
                    FirstName = "Client5",
                    LastName = "LastName5",
                    Document = "789123456",
                    Email = "client5@example.com",
                    PhoneNumber = "7891234560"
                }
            );


            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
