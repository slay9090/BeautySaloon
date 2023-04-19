using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models.types
{
    class CareItem : Model
    {
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }

        public static string schema = $"USE {bdName}; CREATE TABLE `{TableName.cares}` (\r\n  `Id` int NOT NULL AUTO_INCREMENT,\r\n  `Name` text NOT NULL,\r\n  `Price` float NOT NULL,\r\n  PRIMARY KEY (`Id`)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
    }
}
