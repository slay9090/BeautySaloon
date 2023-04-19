using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models.types
{
    class OrderItem
    {
        public string id { get; set; }
        public string idClient { get; set; }
        public string idEmployee { get; set; }
        public string idCare { get; set; }
        public DateTime dateOrder { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string status { get; set; }
    }
}
