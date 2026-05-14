using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class PaymentViewModel
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime PaymentDate { get; set; }

        public static explicit operator Payment(PaymentViewModel vm)
        {
            return new Payment()
            {
                PaymentId = vm.PaymentId,
                Amount = vm.Amount,
                Status = vm.Status,
                IsBlocked = vm.IsBlocked,
                PaymentDate = vm.PaymentDate
            };
        }

        public static explicit operator PaymentViewModel(Payment model)
        {
            return new PaymentViewModel()
            {
                PaymentId = model.PaymentId,
                Amount = model.Amount,
                Status = model.Status,
                IsBlocked = model.IsBlocked,
                PaymentDate = model.PaymentDate
            };
        }
    }
}
