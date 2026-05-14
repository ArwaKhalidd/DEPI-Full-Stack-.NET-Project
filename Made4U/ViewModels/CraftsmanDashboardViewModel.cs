using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class CraftsmanDashboardViewModel
    {
        public int CraftsmanId { get; set; }
        public List<OrderViewModel> AvailableRequests { get; set; }
        public List<OrderViewModel> ActiveOrders { get; set; }
        public List<OrderViewModel> CompletedOrders { get; set; }
        public List<OfferViewModel> MyOffers { get; set; }

        public static CraftsmanDashboardViewModel ToVM
        (
            Craftsman craftsman,
            List<Order> requests,
            List<Order> activeOrders,
            List<Order> completedOrders,
            List<Offer> offers
        )
        {
            return new CraftsmanDashboardViewModel()
            {
                CraftsmanId = craftsman.CraftsmanId,

                AvailableRequests = requests.Select(r => (OrderViewModel)r).ToList(),

                ActiveOrders = activeOrders.Select(o => (OrderViewModel)o).ToList(),

                CompletedOrders = completedOrders.Select(o => (OrderViewModel)o).ToList(),

                MyOffers = offers.Select(o => (OfferViewModel)o).ToList()
            };
        }
    }
}
