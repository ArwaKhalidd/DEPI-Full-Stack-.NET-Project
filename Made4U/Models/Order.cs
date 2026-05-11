using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class Order
    {
        public int OrderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Category { get; set; }
        public int ClientId { get; set; }
    }
}