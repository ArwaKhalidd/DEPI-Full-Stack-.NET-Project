using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class Shipment
    {
        public int ShipmentId { get; set; }
        public string ShippingStatus { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public int OrderId { get; set; }

    }
}