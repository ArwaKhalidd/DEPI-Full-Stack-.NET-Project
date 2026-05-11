using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class ClientProfileViewModel
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ProfileImage { get; set; }

        public static explicit operator Client(ClientProfileViewModel vm)
        {
            return new Client()
            {
                ClientId = vm.ClientId,
                FullName = vm.FullName,
                PhoneNumber = vm.PhoneNumber,
                Address = vm.Address,
                ProfileImage = vm.ProfileImage
            };
        }


        public static explicit operator ClientProfileViewModel(Client model)
        {
            return new ClientProfileViewModel()
            {
                ClientId = model.ClientId,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                ProfileImage = model.ProfileImage
            };
        }
    }
}
