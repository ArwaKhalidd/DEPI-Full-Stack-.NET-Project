using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Made4U.Models
{
    class Craftsman : User
    {
        public int CraftsmanId { get; set; }
        public string NationalId { get; set; }
        public string Bio { get; set; }
        public string VerificationStatus { get; set; }
        public double Rating { get; set; }
        public string Specialization {  get; set; }
    }
}