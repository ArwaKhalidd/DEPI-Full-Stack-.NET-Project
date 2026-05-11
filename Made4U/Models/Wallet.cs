using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Made4U.Models
{
    class Wallet
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal BlockedBalance { get; set; }
    }
}
