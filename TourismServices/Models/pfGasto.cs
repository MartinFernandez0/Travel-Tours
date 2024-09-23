using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfGasto
    {
        public int ID { get; set; }
        public int ItinerarioID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public CategoriaGastoEnum CategoriaGastoEnum { get; set; }
        public string Descripcion { get; set; }
    }

}
