using ATMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary.DAL
{
    // Create a factory class!
    public class PinFactory
    {
        // Factory method - create and instantiate objects!
        public User CreateUser(string u)
        {
            switch (u)
            {
                case "user1": return new User("Admin", 0605);
                case "user2": return new User("Camilla", 3388);
                case "user3": return new User("Mikkel", 6644);
                case "user4": return new User("Jo-Anna", 0506);
                default:
                    return null;
            }
        }
    }
}
