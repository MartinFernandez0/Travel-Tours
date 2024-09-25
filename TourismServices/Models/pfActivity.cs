using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TourismServices.Models
{
    public class pfActivity
    {
        public int ID { get; set; }
        public int ItineraryID { get; set; }
        public string ActivityName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }

}
