using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class OrderTrackingViewModel
    {
        public int OrderId { get; set; }

        public string OrderStatus { get; set; }

        public string ShippingStatus { get; set; }

        public string TrackingNumber { get; set; }

        public DateTime EstimatedArrival { get; set; }

        public string QrCode { get; set; }

        public static OrderTrackingViewModel ToVM
        (
            Order order,
            Shipment shipment
        )
        {
            return new OrderTrackingViewModel()
            {
                OrderId = order.OrderId,
                OrderStatus = order.Status,
                ShippingStatus = shipment.ShippingStatus,
                TrackingNumber = shipment.TrackingNumber,
                EstimatedArrival = shipment.EstimatedArrival
            };
        }

        public static explicit operator Shipment(OrderTrackingViewModel vm)
        {
            return new Shipment()
            {
                OrderId = vm.OrderId,
                ShippingStatus = vm.ShippingStatus,
                TrackingNumber = vm.TrackingNumber,
                EstimatedArrival = vm.EstimatedArrival
            };
        }

        public static explicit operator Order(OrderTrackingViewModel vm)
        {
            return new Order()
            {
                OrderId = vm.OrderId,
                Status = vm.OrderStatus
            };
        }
    }
}
