using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfReserva
    {
        public int ID { get; set; }
        public int AdministradorID { get; set; }
        public int ItinerarioID { get; set; }
        public int ClienteID { get; set; }

        [Required]
        public EstadoReservaEnum EstadoReservaEnum { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
