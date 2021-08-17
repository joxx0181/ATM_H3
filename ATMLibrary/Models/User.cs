using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary.Models
{
    // This class represent User!
    public class User : IUser
    {
        // Create auto implemented properties with get and set accesor!
        public string UName { get; set; }
        public int UPin { get; set; }

        // Constructor declaration with parameters!
        public User(string name, int pin)
        {
            UName = name;
            UPin = pin;
        }

        // Overriding!
        public override string ToString()
        {
            return "\nAccount Owner: " + UName;
        }
    }
}
