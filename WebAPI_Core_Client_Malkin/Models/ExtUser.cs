using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Core_Client_Malkin.Models
{
    public class ExtUser : User
    {
        public new UserType UserType { set; get; }
    }
}
