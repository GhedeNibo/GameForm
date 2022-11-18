using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Core_Client_Malkin.Models
{
    class UserType
    {
        public int ID { get; set; }
        public String TypeName { get; set; }
        public bool Read { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool EditAll { get; set; }
        public bool Delete { get; set; }
        public bool DeleteAll { get; set; }
        public bool RezTable { get; set; }
    }
}
