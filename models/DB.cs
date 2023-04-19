using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BeautySaloon.models.Model;

namespace BeautySaloon.models
{
    class DB : Model
    {
        public string create() {
            return $"CREATE DATABASE IF NOT EXISTS `{bdName}`;";
        }
        public string removeTables()
        {
            string sql =  $"DROP TABLE IF EXISTS {bdName}.{TableName.skills}; " +
                 $"DROP TABLE IF EXISTS {bdName}.{TableName.orders}; " +
                $"DROP TABLE IF EXISTS {bdName}.{TableName.employees}; " +
                $"DROP TABLE IF EXISTS {bdName}.{TableName.cares};  " +
                $"DROP TABLE IF EXISTS {bdName}.{TableName.clients} ;";
            
            return sql ;

        }

        public string generateFakeData() {            
            return $"INSERT INTO {bdName}.{TableName.employees} (FirstName,SurnName,MiddleName,`Position`) VALUES\r\n\t ('Кулачкова','Галина','Петровна','Стажер'),\r\n\t ('Драникова','Мария','Родионовна','Младший мастер'),\r\n\t ('Иванова','Дарья','Андреевна','Мастер'),\r\n\t ('Урюпина','Жанна','Аркадьевна','Мастер'),\r\n\t ('Ежова','Елизавета','Сергеевна','Старший мастер'),\r\n\t ('Стасиковна','Анастасия',NULL,'Мастер');\r\nINSERT INTO {bdName}.{TableName.cares} (Name,Price) VALUES\r\n\t ('Окрашивание волос',2300.0),\r\n\t ('Стрижка волос',1500.0),\r\n\t ('Причёска',900.0),\r\n\t ('Маникюр ',2000.0),\r\n\t ('Педикюр',1455.0),\r\n\t ('Мейкап',999.0),\r\n\t ('Макияж',1000.0),\r\n\t ('Удаление кутикул',1345.0),\r\n\t ('Чистка лица',3211.0);\t \r\nINSERT INTO {bdName}.{TableName.clients} (FirstName,SurnName,MiddleName,PhoneNumber,BirthDate) VALUES\r\n\t ('Ахмеджанова','Таисия','Владимирна','79379999999','2003-04-13'),\r\n\t ('Лалкина','Надежда','Миксимовна','79379990000','2007-11-20');\r\nINSERT INTO {bdName}.{TableName.skills} (IdEmployee,IdCare) VALUES\r\n\t (1,1),\r\n\t (1,3),\r\n\t (2,1),\r\n\t (2,2),\r\n\t (2,3),\r\n\t (2,4),\r\n\t (3,1),\r\n\t (3,2),\r\n\t (3,3),\r\n\t (3,4);\r\nINSERT INTO {bdName}.{TableName.skills} (IdEmployee,IdCare) VALUES\r\n\t (3,5),\r\n\t (3,8),\r\n\t (3,9),\r\n\t (4,1),\r\n\t (4,2),\r\n\t (4,3),\r\n\t (4,4),\r\n\t (4,5),\r\n\t (4,8),\r\n\t (4,9);\r\nINSERT INTO {bdName}.{TableName.skills} (IdEmployee,IdCare) VALUES\r\n\t (5,1),\r\n\t (5,2),\r\n\t (5,3),\r\n\t (5,4),\r\n\t (5,5),\r\n\t (5,6),\r\n\t (5,7),\r\n\t (5,8),\r\n\t (5,9),\r\n\t (6,1);\r\nINSERT INTO {bdName}.{TableName.skills} (IdEmployee,IdCare) VALUES\r\n\t (6,2),\r\n\t (6,3),\r\n\t (6,4),\r\n\t (6,5),\r\n\t (6,8),\r\n\t (6,9);\r\nINSERT INTO {bdName}.{TableName.orders} (IdClient,IdEmployee,IdCare,DateOrder,StartTime,EndTime,Status) VALUES\r\n\t (1,1,1,'2023-04-03','13:00:00','14:00:00','completed'),\r\n\t (1,5,6,'2023-04-10','13:00:00','14:00:00','canceled'),\r\n\t (1,5,6,'2023-04-12','13:00:00','14:00:00','completed'),\r\n\t (2,3,9,'2023-04-29','13:00:00','14:00:00','new');";
                        
        }


    }
   
}
