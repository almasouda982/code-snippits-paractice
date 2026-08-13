using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignment.Accoutns
{
    public class Wallet : IAccount
    {
        public string Phone { get; set; }

        public Wallet(string phone)
        {
            Phone = phone;
        }

        public string DisplayAccount()
        {
            return $"the phone number is {Phone}";
        }
    }
}
