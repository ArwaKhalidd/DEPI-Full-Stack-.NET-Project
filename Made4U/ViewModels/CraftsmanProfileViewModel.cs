using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class CraftsmanProfileViewModel
    {
        public int CraftsmanId { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        public string ProfileImage { get; set; }

        public string Specialization { get; set; }

        public double Rating { get; set; }


        // Portfolio Section

        public List<PortfolioItemViewModel> PortfolioItems { get; set; }


        public static explicit operator Craftsman(CraftsmanProfileViewModel vm)
        {
            return new Craftsman()
            {
                CraftsmanId = vm.CraftsmanId,
                FullName = vm.FullName,
                Bio = vm.Bio,
                ProfileImage = vm.ProfileImage,
                Specialization = vm.Specialization,
                Rating = vm.Rating
            };
        }


        public static explicit operator CraftsmanProfileViewModel(Craftsman model)
        {
            return new CraftsmanProfileViewModel()
            {
                CraftsmanId = model.CraftsmanId,
                FullName = model.FullName,
                Bio = model.Bio,
                ProfileImage = model.ProfileImage,
                Specialization = model.Specialization,
                Rating = model.Rating
            };
        }
    }
}
