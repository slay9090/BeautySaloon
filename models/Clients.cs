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
    internal class Clients : Model
    {
        string tableName = "Clients";


        public string getTableData()
        {
            string sql = $"SELECT * FROM {bdName}.{tableName};";
            return sql;
        }
        public string addRow(ClientItem clientsItem)
        {

            string sql = $"INSERT INTO {bdName}.{tableName} (FirstName, SurnName, MiddleName, PhoneNumber, BirthDate) " +
                        $"VALUES" +
                        $"('{clientsItem.firstName}', " +
                        $"'{clientsItem.surnName}'," +
                        $"'{clientsItem.middleName}'," +
                        $"'{clientsItem.phoneNumber}'," +
                        $"'{clientsItem.birthDate}');";

            return sql;
        }
        public string editRow(ClientItem clientsItem)
        {
            string sql = $"UPDATE {bdName}.{tableName} " +
                $"SET FirstName='{clientsItem.firstName}', " +
                $"SurnName='${clientsItem.surnName}', " +
                $"MiddleName='{clientsItem.middleName}', " +
                $"PhoneNumber='{clientsItem.phoneNumber}' " +
                $"BirthDate='{clientsItem.birthDate}' " +
                $"WHERE Id={clientsItem.id};";
            return sql;
        }

        public string getTableFilteredData(string str)
        {
            string sql = $"SELECT * FROM {bdName}.{tableName} WHERE " +
                $"FirstName LIKE '%{str}%' OR " +
                $"SurnName LIKE '%{str}%' OR " +
                $"MiddleName LIKE '%{str}%' OR " +
                $"PhoneNumber LIKE '%{str}%';";
            return sql;
        }
        public string deleteRow(ClientItem clientsItem)
        {
            string sql = $"DELETE FROM {bdName}.{tableName} " +
                $"WHERE Id={clientsItem.id};";
            return sql;
        }
    }
}
