using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary.Models
{
    // This class represent Account!
    public class Account 
    {
        // Create auto implemented properties with get and set accesor!
        public string AType { get; set; }
        public long ANum { get; set; }
        public double ABalance { get; set; }

        // Constructor declaration with parameters!
        public Account(string type, long number, double balance)
        {
            AType = type;
            ANum = number;
            ABalance = balance;

        }

        // Overriding!
        public override string ToString()
        {
            return "\nAccount Type: " + AType + "\nAccount Number: " + ANum + "\nAccount Balance: " + ABalance;
        }

        // Using this method for adding to account balance!
        public static double AddToAccount(double x, double y)
        {
            return x + y;
        }

        // Using this method for withdraw from account balance!
        public static double WithDrawFromAccount(double x, double y)
        {
            return x - y;
        }
    }
}
