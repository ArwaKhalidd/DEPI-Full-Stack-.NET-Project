using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class OfferViewModel
    {
        public int OfferId { get; set; }

        public decimal Price { get; set; }

        public int DurationInDays { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string CraftsmanName { get; set; }

        public double CraftsmanRating { get; set; }

        public string CraftsmanImage { get; set; }


        public static explicit operator Offer(OfferViewModel vm)
        {
            return new Offer()
            {
                OfferId = vm.OfferId,
                Price = vm.Price,
                DurationInDays = vm.DurationInDays,
                Description = vm.Description,
                Status = vm.Status
            };
        }


        public static explicit operator OfferViewModel(Offer model)
        {
            return new OfferViewModel()
            {
                OfferId = model.OfferId,
                Price = model.Price,
                DurationInDays = model.DurationInDays,
                Description = model.Description,
                Status = model.Status
            };
        }
    }
}
