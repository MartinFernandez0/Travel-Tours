using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfExpense
    {
        public int ID { get; set; }
        public int ItineraryID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public ExpenseCategoryEnum ExpenseCategory { get; set; }
        public string Description { get; set; }
    }

}
