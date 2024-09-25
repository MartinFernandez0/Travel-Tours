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

        // DbSets para tus modelos en el orden especificado
        public DbSet<pfActividad> pfActividades { get; set; }
        public DbSet<pfAdministrador> pfAdministradores { get; set; }
        public DbSet<pfDestino> pfDestinos { get; set; }
        public DbSet<pfGasto> pfGastos { get; set; }
        public DbSet<pfItinerario> pfItinerarios { get; set; }
        public DbSet<pfReserva> pfReservas { get; set; }
        public DbSet<pfTransaccion> pfTransacciones { get; set; }
        public DbSet<pfCliente> pfClientes { get; set; }


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
            // Datos semilla para pfAdministradores
            modelBuilder.Entity<pfAdministrador>().HasData(
                new pfAdministrador
                {
                    ID = 1,
                    Nombre = "Martin",
                    Apellido = "Fernandez",
                    Email = "martin_fernandez@example.com",
                    Telefono = "3498479331",
                    FechaRegistro = DateTime.Now
                }
            );

            // Datos semilla para pfDestinos
            modelBuilder.Entity<pfDestino>().HasData(
                new pfDestino
                {
                    ID = 1,
                    Nombre = "París",
                    Descripcion = "Ciudad del amor",
                    Pais = "Francia"

                },
                new pfDestino
                {
                    ID = 2,
                    Nombre = "Nueva York",
                    Descripcion = "La gran manzana",
                    Pais = "Estados Unidos"
                }
            );

            // Datos semilla para pfActividades
            modelBuilder.Entity<pfActividad>().HasData(
                new pfActividad
                {
                    ID = 1,
                    NombreActividad = "Visita a la Torre Eiffel",
                    Descripcion = "Tour guiado a la Torre Eiffel",
                    Fecha = DateTime.Now,
                    ItinerarioID = 1
                },
                new pfActividad
                {
                    ID = 2,
                    NombreActividad = "Paseo en barco por el Hudson",
                    Descripcion = "Crucero por el río Hudson",
                    Fecha = DateTime.Now,
                    ItinerarioID = 2
                }
            );

            // Datos semilla para pfGastos
            modelBuilder.Entity<pfGasto>().HasData(
                new pfGasto
                {
                    ID = 1,
                    Monto = 100.00m,
                    CategoriaGastoEnum = CategoriaGastoEnum.Alojamiento,
                    Descripcion = "Hotel en París",
                    Fecha = DateTime.Now,
                    ItinerarioID = 1
                },
                new pfGasto
                {
                    ID = 2,
                    Monto = 50.00m,
                    CategoriaGastoEnum = CategoriaGastoEnum.Comida,
                    Descripcion = "Comida en Nueva York",
                    Fecha = DateTime.Now,
                    ItinerarioID = 2
                }
            );

            // Datos semilla para pfItinerarios
            modelBuilder.Entity<pfItinerario>().HasData(
                new pfItinerario
                {
                    ID = 1,
                    Destino = "París",
                    FechaSalida = DateTime.Now.AddDays(7),
                    FechaRegreso = DateTime.Now.AddDays(14),
                    Descripcion = "Viaje a París"
                },
                new pfItinerario
                {
                    ID = 2,
                    Destino = "Nueva York",
                    FechaSalida = DateTime.Now.AddDays(21),
                    FechaRegreso = DateTime.Now.AddDays(28),
                    Descripcion = "Viaje a Nueva York"
                }
            );

            // Datos semilla para pfReservas
            modelBuilder.Entity<pfReserva>().HasData(
                new pfReserva
                {
                    ID = 1,
                    ClienteID = 1,
                    ItinerarioID = 1,
                    FechaReserva = DateTime.Now,
                    EstadoReservaEnum = EstadoReservaEnum.Confirmada
                }
            );

            // Datos semilla para pfTransacciones
            modelBuilder.Entity<pfTransaccion>().HasData(
                new pfTransaccion
                {
                    ID = 1,
                    Monto = 1500.00m,
                    Fecha = DateTime.Now,
                    ClienteID = 1,
                    ItinerarioID = 1,
                    ConfirmacionPagoEnum = ConfirmacionPagoEnum.Confirmado,
                    FormaDePagoEnum = FormaPagoEnum.TarjetaDeCredito
                },
                new pfTransaccion
                {
                    ID = 2,
                    Monto = 2000.00m,
                    Fecha = DateTime.Now,
                    ClienteID = 2,
                    ItinerarioID = 2,
                    ConfirmacionPagoEnum = ConfirmacionPagoEnum.Rechazado,
                    FormaDePagoEnum = FormaPagoEnum.TarjetaDeDebito
                },
                new pfTransaccion
                {
                    ID = 3,
                    Monto = 500.00m,
                    Fecha = DateTime.Now,
                    ClienteID = 3,
                    ItinerarioID = 1,
                    ConfirmacionPagoEnum = ConfirmacionPagoEnum.Reembolsado,
                    FormaDePagoEnum = FormaPagoEnum.TransferenciaBancaria
                }
            );

            // Datos semilla para pfClientes
            modelBuilder.Entity<pfCliente>().HasData(
                new pfCliente
                {
                    ID = 1,
                    Nombre = "Cliente1",
                    Apellido = "Apellido1",
                    Documento = "123456789",
                    Email = "cliente1@example.com",
                    Telefono = "1234567890"
                },
                new pfCliente
                {
                    ID = 2,
                    Nombre = "Cliente2",
                    Apellido = "Apellido2",
                    Documento = "987654321",
                    Email = "cliente2@example.com",
                    Telefono = "0987654321"
                },
                new pfCliente
                {
                    ID = 3,
                    Nombre = "Cliente3",
                    Apellido = "Apellido3",
                    Documento = "456789123",
                    Email = "cliente3@example.com",
                    Telefono = "4567891230"
                },
                new pfCliente
                {
                    ID = 4,
                    Nombre = "Cliente4",
                    Apellido = "Apellido4",
                    Documento = "321654987",
                    Email = "cliente4@example.com",
                    Telefono = "3216549870"
                },
                new pfCliente
                {
                    ID = 5,
                    Nombre = "Cliente5",
                    Apellido = "Apellido5",
                    Documento = "789123456",
                    Email = "cliente5@example.com",
                    Telefono = "7891234560"
                }
            );


            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
