using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class OrderRejection
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string RejectReason { get; set; }
        public DateTime RejectDate { get; set; }
    }
}
