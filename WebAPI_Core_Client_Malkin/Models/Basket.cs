using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Core_Client_Malkin.Models
{
    class Basket
    {
        public int ID { get; set; }
        public int GameId { get; set; }
        public int Count { get; set; }
        public int UserId { get; set; }
    }
}
