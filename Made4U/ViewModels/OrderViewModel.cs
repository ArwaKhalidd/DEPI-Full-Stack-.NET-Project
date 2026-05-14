using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class OrderViewModel
    {
        public int OrderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Category { get; set; }

        public static explicit operator OrderViewModel(Order model)
        {
            return new OrderViewModel()
            {
                OrderId = model.OrderId,
                Title = model.Title,
                Description = model.Description,
                Budget = model.Budget,
                Deadline = model.Deadline,
                Status = model.Status,
                CreatedAt = model.CreatedAt,
                Category = model.Category
            };
        }

        public static explicit operator Order(OrderViewModel vm)
        {
            return new Order()
            {
                OrderId = vm.OrderId,
                Title = vm.Title,
                Description = vm.Description,
                Budget = vm.Budget,
                Deadline = vm.Deadline,
                Status = vm.Status,
                CreatedAt = vm.CreatedAt,
                Category = vm.Category
            };
        }
    }
}
