using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class ComplaintViewModel
    {
        public int ComplaintId { get; set; }
        public string Reason { get; set; }

        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public static explicit operator Complaint(ComplaintViewModel vm)
        {
            return new Complaint()
            {
                ComplaintId = vm.ComplaintId,
                Reason = vm.Reason,
                Status = vm.Status,
                CreatedAt = vm.CreatedAt
            };
        }

        public static explicit operator ComplaintViewModel(Complaint model)
        {
            return new ComplaintViewModel()
            {
                ComplaintId = model.ComplaintId,
                Reason = model.Reason,
                Status = model.Status,
                CreatedAt = model.CreatedAt
            };
        }
    }
}
