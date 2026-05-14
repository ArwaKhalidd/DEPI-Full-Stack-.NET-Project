using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class CreateOrderViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public decimal Budget { get; set; }

        public DateTime Deadline { get; set; }

        public List<string> Images { get; set; }

        public static explicit operator Order(CreateOrderViewModel vm)
        {
            return new Order()
            {
                Title = vm.Title,
                Description = vm.Description,
                Category = vm.Category,
                Budget = vm.Budget,
                Deadline = vm.Deadline
            };
        }


        public static explicit operator CreateOrderViewModel(Order model)
        {
            return new CreateOrderViewModel()
            {
                Title = model.Title,
                Description = model.Description,
                Category = model.Category,
                Budget = model.Budget,
                Deadline = model.Deadline
            };
        }
    }
}
