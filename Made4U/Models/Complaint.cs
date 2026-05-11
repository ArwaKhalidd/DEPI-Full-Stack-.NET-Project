using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class Complaint
    {
        public int ComplaintId { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string AdminDecision { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}