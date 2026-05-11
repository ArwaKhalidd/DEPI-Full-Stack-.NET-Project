using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class ClientDashboardViewModel
    {
        public int ClientId { get; set; }
        public List<OrderViewModel> ActiveOrders { get; set; }
        public List<OrderViewModel> CompletedOrders { get; set; }
        public List<OrderViewModel> PendingOrders { get; set; }

        public static ClientDashboardViewModel ToVM(int clientId,List<Order> orders)
        {
            return new ClientDashboardViewModel()
            {
                ClientId = clientId,

                ActiveOrders = orders.Where(o => o.Status == "InProgress").Select(o => (OrderViewModel)o).ToList(),

                CompletedOrders = orders.Where(o => o.Status == "Completed").Select(o => (OrderViewModel)o).ToList(),

                PendingOrders = orders.Where(o => o.Status == "Pending").Select(o => (OrderViewModel)o).ToList()
            };
        }
    }
}
