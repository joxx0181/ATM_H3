using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary.Models
{
    // This interface represent IUser!
    public interface IUser
    {
        string UName { get; set; }
        int UPin { get; set; }
    }
}
