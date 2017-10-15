using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTCBusPass.Models;

namespace DTCBusPass.Interfaces
{
    interface IUser
    {
        User GetUserDetails(string emailAddress);                        
    }
}
