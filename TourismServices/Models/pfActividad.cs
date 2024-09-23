using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TourismServices.Models
{
    public class pfActividad
    {
        public int ID { get; set; }
        public int ItinerarioID { get; set; }
        public string NombreActividad { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }

}
