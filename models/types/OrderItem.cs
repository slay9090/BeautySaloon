using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models.types
{
    class OrderItem : Model
    {
        public string id { get; set; }
        public string idClient { get; set; }
        public string idEmployee { get; set; }
        public string idCare { get; set; }
        public DateTime dateOrder { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string status { get; set; }

        public static string schema = $"USE {bdName}; CREATE TABLE `{TableName.orders}` (\r\n  `Id` int NOT NULL AUTO_INCREMENT,\r\n  `IdClient` int NOT NULL,\r\n  `IdEmployee` int NOT NULL,\r\n  `IdCare` int NOT NULL,\r\n  `DateOrder` date NOT NULL,\r\n  `StartTime` time NOT NULL,\r\n  `EndTime` time NOT NULL,\r\n  `Status` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,\r\n  PRIMARY KEY (`Id`),\r\n  KEY `Orders_FK` (`IdClient`),\r\n  KEY `Orders_FK_1` (`IdEmployee`),\r\n  KEY `Orders_FK_2` (`IdCare`),\r\n  CONSTRAINT `Orders_FK` FOREIGN KEY (`IdClient`) REFERENCES `Clients` (`Id`),\r\n  CONSTRAINT `Orders_FK_1` FOREIGN KEY (`IdEmployee`) REFERENCES `Employees` (`Id`),\r\n  CONSTRAINT `Orders_FK_2` FOREIGN KEY (`IdCare`) REFERENCES `Cares` (`Id`)\r\n) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
    }
}
