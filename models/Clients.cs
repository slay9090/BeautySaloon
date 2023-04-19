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
        


        public string getTableData()
        {
            string sql = $"SELECT *, CONCAT(FirstName, ' ', SurnName) as FullName " +
                $"FROM {bdName}.{TableName.clients};";            
            return sql;
        }
        public string addRow(ClientItem clientsItem)
        {

            string sql = $"INSERT INTO {bdName}.{TableName.clients} (FirstName, SurnName, MiddleName, PhoneNumber, BirthDate) " +
                        $"VALUES" +
                        $"('{clientsItem.firstName}', " +
                        $"'{clientsItem.surnName}'," +
                        $"'{clientsItem.middleName}'," +
                        $"'{clientsItem.phoneNumber}'," +
                        $"'{clientsItem.birthDate:yyyy-MM-dd}');";

            return sql;
        }
        public string editRow(ClientItem clientsItem)
        {
            string sql = $"UPDATE {bdName}.{TableName.clients} " +
                $"SET FirstName='{clientsItem.firstName}', " +
                $"SurnName='{clientsItem.surnName}', " +
                $"MiddleName='{clientsItem.middleName}', " +
                $"PhoneNumber='{clientsItem.phoneNumber}', " +
                $"BirthDate='{clientsItem.birthDate:yyyy-MM-dd}' " +
                $"WHERE Id={clientsItem.id};";
            return sql;
        }

        public string getTableFilteredData(string str)
        {
            string sql = $"SELECT * FROM {bdName}.{TableName.clients} WHERE " +
                $"FirstName LIKE '%{str}%' OR " +
                $"SurnName LIKE '%{str}%' OR " +
                $"MiddleName LIKE '%{str}%' OR " +
                $"PhoneNumber LIKE '%{str}%';";
            return sql;
        }
        public string deleteRow(ClientItem clientsItem)
        {
            string sql = $"DELETE FROM {bdName}.{TableName.clients} " +
                $"WHERE Id={clientsItem.id};";
            return sql;
        }
    }
}
