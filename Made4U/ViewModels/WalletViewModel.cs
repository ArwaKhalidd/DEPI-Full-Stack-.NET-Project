using Made4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.ViewModels
{
    class WalletViewModel
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal BlockedBalance { get; set; }

        public static explicit operator Wallet(WalletViewModel vm)
        {
            return new Wallet()
            {
                Id = vm.Id,
                Balance = vm.Balance,
                BlockedBalance = vm.BlockedBalance
            };
        }

        public static explicit operator WalletViewModel(Wallet model)
        {
            return new WalletViewModel()
            {
                Id = model.Id,
                Balance = model.Balance,
                BlockedBalance = model.BlockedBalance
            };
        }
    }
}
