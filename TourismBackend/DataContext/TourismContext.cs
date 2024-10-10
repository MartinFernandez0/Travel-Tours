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
        public DbSet<pfAdministrator> pfAdministrators { get; set; }
        public DbSet<pfClient> pfClients { get; set; }
        public DbSet<pfActivity> pfActivities { get; set; }
        public DbSet<pfDestination> pfDestinations { get; set; }
        public DbSet<pfItinerary> pfItineraries { get; set; }
        public DbSet<pfReservation> pfReservations { get; set; }
        public DbSet<pfTransaction> pfTransactions { get; set; }


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
            // Seed data for pfActivity
            modelBuilder.Entity<pfActivity>().HasData(
                new pfActivity
                {
                    ID = 1,
                    ActivityName = "Eiffel Tower Visit",
                    Description = "Guided tour of the Eiffel Tower",
                    Duration = 3, // in hours
                    Cost = 30.00m,
                    URLimage = "https://imgs.search.brave.com/ifM8jJudxdlseBcPdMm8ql0MWz9JgP3R1sugQ7Q2WzA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/Y3VsdHVyYWdlbmlh/bC5jb20vZXMvaW1h/Z2VuZXMvdG9ycmUt/ZWlmZmVsLWNrZS5q/cGc_Y2xhc3M9YXJ0/aWNsZQ"
                },
                new pfActivity
                {
                    ID = 2,
                    ActivityName = "Hudson River Cruise",
                    Description = "Boat tour along the Hudson River",
                    Duration = 2, // in hours
                    Cost = 50.00m,
                    URLimage = "https://imgs.search.brave.com/zuhiGpSpdxrdQSGxmpnztHWQX-jfCQUae6Xa0mzj9Q8/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9hY2xt/ZWRpYS5henVyZWVk/Z2UubmV0L2Ntc21l/ZGlhL2xpYnJhcmll/cy9hY2wvaW1hZ2Vz/L2NydWlzZXMvaHVk/c29uLXJpdmVyLWNy/dWlzZXMvYWNsX3dl/YnNpdGVfNzAweDUw/MF9odWRzb25fY3J1/aXNpbmdfb3ZlcnZp/ZXcyLmpwZz9leHQ9/LmpwZw"
                }
            );

            // Seed data for pfDestination
            modelBuilder.Entity<pfDestination>().HasData(
                new pfDestination
                {
                    ID = 1,
                    Name = "Paris",
                    Country = "France",
                    Description = "The City of Lights",
                    URL_image = "https://imgs.search.brave.com/ifM8jJudxdlseBcPdMm8ql0MWz9JgP3R1sugQ7Q2WzA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/Y3VsdHVyYWdlbmlh/bC5jb20vZXMvaW1h/Z2VuZXMvdG9ycmUt/ZWlmZmVsLWNrZS5q/cGc_Y2xhc3M9YXJ0/aWNsZQ",
                    CategoryName = "City",
                },
                new pfDestination
                {
                    ID = 2,
                    Name = "New York",
                    Country = "USA",
                    Description = "The Big Apple",
                    URL_image = "https://www.travel-guide.es/media/new-york.jpeg",
                    CategoryName = "City",
                }
            );

            // Seed data for pfItinerary
            modelBuilder.Entity<pfItinerary>().HasData(
                new pfItinerary
                {
                    ID = 1,
                    Name = "Paris",
                    DestinationID = 1, // FK to pfDestination
                    DepartureDate = DateTime.Now.AddDays(7),
                    ReturnDate = DateTime.Now.AddDays(14),
                    Description = "Trip to Paris"
                },
                new pfItinerary
                {
                    ID = 2,
                    Name = "New York",
                    DestinationID = 2, // FK to pfDestination
                    DepartureDate = DateTime.Now.AddDays(21),
                    ReturnDate = DateTime.Now.AddDays(28),
                    Description = "Trip to New York"
                }
            );

            // Seed data for pfReservation
            modelBuilder.Entity<pfReservation>().HasData(
                new pfReservation
                {
                    ID = 1,
                    ClientID = 1, // FK to pfClient
                    ItineraryID = 1, // FK to pfItinerary
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Confirmed
                },
                new pfReservation
                {
                    ID = 2,
                    ClientID = 2, // FK to pfClient
                    ItineraryID = 2, // FK to pfItinerary
                    ReservationDate = DateTime.Now,
                    ReservationStatus = ReservationStatusEnum.Pending
                }
            );

            // Seed data for pfTransaction
            modelBuilder.Entity<pfTransaction>().HasData(
                new pfTransaction
                {
                    ID = 1,
                    Amount = 1500.00m,
                    TransactionDate = DateTime.Now,
                    ClientID = 1, // FK to pfClient
                    PaymentConfirmation = PaymentConfirmationEnum.Confirmed,
                    PaymentMethod = PaymentMethodEnum.CreditCard
                },
                new pfTransaction
                {
                    ID = 2,
                    Amount = 2000.00m,
                    TransactionDate = DateTime.Now,
                    ClientID = 2, // FK to pfClient
                    PaymentConfirmation = PaymentConfirmationEnum.Rejected,
                    PaymentMethod = PaymentMethodEnum.CreditCard
                },
                new pfTransaction
                {
                    ID = 3,
                    Amount = 500.00m,
                    TransactionDate = DateTime.Now,
                    ClientID = 1, // FK to pfClient
                    PaymentConfirmation = PaymentConfirmationEnum.Refunded,
                    PaymentMethod = PaymentMethodEnum.PayPal
                }
            );

        }
    }
}
