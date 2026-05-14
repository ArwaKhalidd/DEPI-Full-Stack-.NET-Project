using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class DeliveryConfirmationViewModel
    {
        public int OrderId { get; set; }
        public string QrCode { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime ConfirmationDate { get; set; }

        public static explicit operator DeliveryConfirmation(DeliveryConfirmationViewModel vm)
        {
            return new DeliveryConfirmation()
            {
                OrderId = vm.OrderId,
                IsConfirmed = vm.IsConfirmed,
                ConfirmationDate = vm.ConfirmationDate
            };
        }

        public static explicit operator DeliveryConfirmationViewModel(DeliveryConfirmation model)
        {
            return new DeliveryConfirmationViewModel()
            {
                OrderId = model.OrderId,
                IsConfirmed = model.IsConfirmed,
                ConfirmationDate = model.ConfirmationDate
            };
        }
    }
}
