using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBookingWeb.Models
{
    public class Travel
    {
        public int Id { get; set; }
        public string TravelFrom { get; set; }
        public int TravelTo { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public Travel()
        {

        }

    }
}
