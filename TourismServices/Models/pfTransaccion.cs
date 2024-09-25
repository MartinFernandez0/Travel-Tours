using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfTransaccion
    {
        public int ID { get; set; }
        public int AdministradorID { get; set; }
        public int ItinerarioID { get; set; }
        public int ClienteID { get; set; }
        public FormaPagoEnum FormaDePagoEnum { get; set; }
        public ConfirmacionPagoEnum ConfirmacionPagoEnum { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

    }

}
