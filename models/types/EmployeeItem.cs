using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models.Types
{
    class EmployeeItem : Model
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string surnName   { get; set; }
        public string middleName { get; set; }
        public string position { get; set; }

        public static string schema = $"USE {bdName}; CREATE TABLE `{TableName.employees}` (\r\n  `FirstName` varchar(100) NOT NULL,\r\n  `SurnName` varchar(100) NOT NULL,\r\n  `MiddleName` varchar(100) DEFAULT NULL,\r\n  `Id` int NOT NULL AUTO_INCREMENT,\r\n  `Position` text NOT NULL,\r\n  PRIMARY KEY (`Id`)\r\n) ENGINE=InnoDB CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
    }
}
