using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models.types
{
    class SkillItem : Model
    {
        public string idCare { get; set; }
        public string idEmployee { get; set; }

        public static string schema = $"USE {bdName}; CREATE TABLE `{TableName.skills}` (\r\n  `IdCare` int NOT NULL,\r\n  `IdEmployee` int NOT NULL,\r\n  PRIMARY KEY (`IdCare`,`IdEmployee`),\r\n  KEY `CareToEmployee_FK_1` (`IdEmployee`),\r\n  CONSTRAINT `CareToEmployee_FK` FOREIGN KEY (`IdCare`) REFERENCES `Cares` (`Id`),\r\n  CONSTRAINT `CareToEmployee_FK_1` FOREIGN KEY (`IdEmployee`) REFERENCES `Employees` (`Id`)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";

    }
}
