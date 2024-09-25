using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfReservation
    {
        public int ID { get; set; }
        public int AdministratorID { get; set; }
        public int ItineraryID { get; set; }
        public int ClientID { get; set; }

        [Required]
        public ReservationStatusEnum ReservationStatus { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
