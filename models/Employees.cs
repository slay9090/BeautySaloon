using BeautySaloon.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySaloon.models
{
    internal class Employees : Model
    {
        string tableName = "Employees";


        public string getTableData() {
            Console.WriteLine("bdName"+ bdName);
            string sql = $"SELECT * FROM {bdName}.{tableName};";
            return sql ;
        }

        public string add() {

            return "";
                }
    }
}
