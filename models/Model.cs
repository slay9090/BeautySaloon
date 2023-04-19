using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models
{

    public class Model
    {
        public static string bdName;

        public class TableName {
            public static string orders = "Orders";
            public static string employees = "Employees";
            public static string cares = "Cares";
            public static string clients = "Clients";
            public static string skills = "CareToEmployee";
        }
    }
}
