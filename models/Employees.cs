using BeautySaloon.controllers;
using BeautySaloon.models.Types;
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

        public string addRow(EmployeeItem employeeItem)
        {

            string sql = $"INSERT INTO {bdName}.{tableName} (FirstName, SurnName, MiddleName, `Position`) " +
                $"VALUES" +
                $"('{employeeItem.firstName}', " +
                $"'{employeeItem.surnName}'," +
                $"'{employeeItem.middleName}'," +
                $"'{employeeItem.position}');";

            return sql;
        }
        public string editRow(EmployeeItem employeeItem) {

            string sql = $"UPDATE {bdName}.{tableName} " +
                $"SET FirstName='{employeeItem.firstName}', " +
                $"SurnName='${employeeItem.surnName}', " +
                $"MiddleName='{employeeItem.middleName}', " +
                $"`Position`='{employeeItem.position}' " +
                $"WHERE Id={employeeItem.id};";
            return sql; 
        }

        public string getTableFilteredData(string str) {

            string sql = $"SELECT * FROM {bdName}.{tableName} WHERE " +
                $"FirstName LIKE '%{str}%' OR " +
                $"SurnName LIKE '%{str}%' OR " +
                $"MiddleName LIKE '%{str}%' OR " +
                $"Position LIKE '%{str}%';";
            return sql;
        }
        public string deleteRow(EmployeeItem employeeItem) {
            string sql = $"DELETE FROM {bdName}.{tableName} " +
                $"WHERE Id={employeeItem.id};";
            return sql;
        }
    }
}
