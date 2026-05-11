using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class AdminDashboardViewModel
    {
        public int TotalClients { get; set; }
        public int TotalCraftsmen { get; set; }
        public int PendingVerifications { get; set; }
        public int ActiveOrders { get; set; }
        public int ComplaintsCount { get; set; }
        public int PendingRequests { get; set; }

        public static AdminDashboardViewModel ToVM
        (
            int totalClients,
            int totalCraftsmen,
            int pendingVerifications,
            int activeOrders,
            int complaintsCount,
            int pendingRequests
        )
        {
            return new AdminDashboardViewModel()
            {
                TotalClients = totalClients,
                TotalCraftsmen = totalCraftsmen,
                PendingVerifications = pendingVerifications,
                ActiveOrders = activeOrders,
                ComplaintsCount = complaintsCount,
                PendingRequests = pendingRequests
            };
        }
    }
}
