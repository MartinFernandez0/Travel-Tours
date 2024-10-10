using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TourismServices.Models
{
    public class pfActivity
    {
        public int ID { get; set; }
        public string ActivityName { get; set; }
        public string URLimage { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
    }

}
