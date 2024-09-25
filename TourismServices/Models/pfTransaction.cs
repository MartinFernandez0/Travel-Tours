﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfTransaction
    {
        public int ID { get; set; }
        public int AdministratorID { get; set; }
        public int ItineraryID { get; set; }
        public int ClientID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public PaymentConfirmationEnum PaymentConfirmation { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

    }

}
