using BeautySaloon.controllers;
using BeautySaloon.models.types;
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
        


        public string getTableData() {
            string sql = $"SELECT * FROM {bdName}.{TableName.employees};";
            return sql ;
        }

        public string addRow(EmployeeItem employeeItem)
        {

            string sql = $"INSERT INTO {bdName}.{TableName.employees} (FirstName, SurnName, MiddleName, `Position`) " +
                $"VALUES" +
                $"('{employeeItem.firstName}', " +
                $"'{employeeItem.surnName}'," +
                $"'{employeeItem.middleName}'," +
                $"'{employeeItem.position}');";

            return sql;
        }
        public string editRow(EmployeeItem employeeItem) {

            string sql = $"UPDATE {bdName}.{TableName.employees} " +
                $"SET FirstName='{employeeItem.firstName}', " +
                $"SurnName='${employeeItem.surnName}', " +
                $"MiddleName='{employeeItem.middleName}', " +
                $"`Position`='{employeeItem.position}' " +
                $"WHERE Id={employeeItem.id};";
            return sql; 
        }

        public string getTableFilteredData(string str) {

            string sql = $"SELECT * FROM {bdName}.{TableName.employees} WHERE " +
                $"FirstName LIKE '%{str}%' OR " +
                $"SurnName LIKE '%{str}%' OR " +
                $"MiddleName LIKE '%{str}%' OR " +
                $"Position LIKE '%{str}%';";
            return sql;
        }
        public string deleteRow(EmployeeItem employeeItem) {
            string sql = $"DELETE FROM {bdName}.{TableName.employees} " +
                $"WHERE Id={employeeItem.id};";
            return sql;
        }

        public string getTableDataByCareId(string careId) {

            string sql = $"SELECT FirstName, SurnName, MiddleName, Id, `Position`, " +
                $"CONCAT(FirstName, ' ', SurnName) as FullName " +
                $"FROM {bdName}.{TableName.employees} " +
                $"LEFT JOIN {bdName}.{TableName.skills} ON {TableName.skills}.IdEmployee = {TableName.employees}.Id " +
                $"WHERE {TableName.skills}.IdCare = {careId} ;";

            return sql;
        }
    }
}
