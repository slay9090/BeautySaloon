using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models
{
    internal class DB : Model
    {

        // string dbName = controllers.ConnectInfo.DBName;

        public string create() {

            employeesModel = new Employees();

            Console.WriteLine(employeesModel.getTableData());

            return $"CREATE DATABASE IF NOT EXISTS `{bdName}`;";
        }
        public void remove(string dbName)
        {

        }
        public void generate() {
        }
    }
}
