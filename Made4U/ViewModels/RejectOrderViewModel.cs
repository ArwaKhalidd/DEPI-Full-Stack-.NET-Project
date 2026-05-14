using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class RejectOrderViewModel
    {
        public int OrderId { get; set; }
        public string RejectReason { get; set; }
        public DateTime RejectDate { get; set; }

        public static explicit operator OrderRejection(RejectOrderViewModel vm)
        {
            return new OrderRejection()
            {
                OrderId = vm.OrderId,
                RejectReason = vm.RejectReason,
                RejectDate = vm.RejectDate
            };
        }

        public static explicit operator RejectOrderViewModel(OrderRejection model)
        {
            return new RejectOrderViewModel()
            {
                OrderId = model.OrderId,
                RejectReason = model.RejectReason,
                RejectDate = model.RejectDate
            };
        }
    }
}
