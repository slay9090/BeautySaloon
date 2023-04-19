using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models.types
{
     class ClientItem : Model
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string surnName { get; set; }
        public string middleName { get; set; }
        public string phoneNumber { get; set; }
        public DateTime birthDate { get; set; }

        public static string schema = $"USE {bdName}; CREATE TABLE `{TableName.clients}` (\r\n  `Id` int NOT NULL AUTO_INCREMENT,\r\n  `FirstName` varchar(100) NOT NULL,\r\n  `SurnName` varchar(100) NOT NULL,\r\n  `MiddleName` varchar(100) DEFAULT NULL,\r\n  `PhoneNumber` varchar(20) NOT NULL,\r\n  `BirthDate` date NOT NULL,\r\n  PRIMARY KEY (`Id`)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
    }
}
