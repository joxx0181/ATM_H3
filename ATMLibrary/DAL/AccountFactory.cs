using ATMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary.DAL
{
    // Create a factory class!
    public class AccountFactory
    {
        // Factory method - create and instantiate objects!
        public Account CreateAccount(string a)
        {
            switch (a)
            {
                case "account1": return new Account("Visa", 4440999999, 0);
                case "account2": return new Account("Kreditkort",4440500005, 500);
                case "account3": return new Account("Hævekort",4440250052, 250);
                case "account4": return new Account("Mastercart",4440100001, 10000);
                default:
                    return null;
            }
        }
    }
}
