using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class DeliveryConfirmation
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public bool IsConfirmed { get; set; }

        public DateTime ConfirmationDate { get; set; }
    }
}
