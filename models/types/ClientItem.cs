using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models.types
{
     class ClientItem
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string surnName { get; set; }
        public string middleName { get; set; }
        public string phoneNumber { get; set; }
        public DateTime birthDate { get; set; }
    }
}
