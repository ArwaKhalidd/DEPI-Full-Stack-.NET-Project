using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class PortfolioItemViewModel
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public static explicit operator Portfolio(PortfolioItemViewModel vm)
        {
            return new Portfolio()
            {
                PortfolioId = vm.PortfolioId,
                Title = vm.Title,
                Description = vm.Description,
                Image = vm.Image
            };
        }

        public static explicit operator PortfolioItemViewModel(Portfolio model)
        {
            return new PortfolioItemViewModel()
            {
                PortfolioId = model.PortfolioId,
                Title = model.Title,
                Description = model.Description,
                Image = model.Image
            };
        }
    }
}
