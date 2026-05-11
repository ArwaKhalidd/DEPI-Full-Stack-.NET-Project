using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class Offer
    {
        public int OfferId { get; set; }
        public decimal Price { get; set; }
        public int DurationInDays { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}