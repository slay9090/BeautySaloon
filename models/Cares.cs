using BeautySaloon.models.types;
using BeautySaloon.models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models
{
    internal class Cares : Model
    {
        string tableName = "Cares";


        public string getTableData()
        { 
            string sql = $"SELECT * FROM {bdName}.{tableName};";
            return sql;
        }

        public string addRow(CareItem careItem)
        {

            string sql = $"INSERT INTO {bdName}.{tableName} (Name, Price) " +
                $"VALUES" +
                $"('{careItem.name}', " +    
                $"'{careItem.price}');";

            return sql;
        }
        public string editRow(CareItem careItem)
        {
            string sql = $"UPDATE {bdName}.{tableName} " +
                $"SET Name='{careItem.name}', " +
                $"Price='{careItem.price}' " +
                $"WHERE Id={careItem.id};";
            return sql;
        }

        public string getTableFilteredData(string str)
        {
            string sql = $"SELECT * FROM {bdName}.{tableName} WHERE " +
                $"Name LIKE '%{str}%' OR " +         
                $"Price LIKE '%{str}%';";
            return sql;
        }
        public string deleteRow(CareItem careItem)
        {
            string sql = $"DELETE FROM {bdName}.{tableName} " +
                $"WHERE Id={careItem.id};";
            return sql;
        }
    }
}
