using BeautySaloon.models.types;
using BeautySaloon.models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models
{
    internal class Orders : Model
    {
        
        public string getTableData() {
            string sql = $"SELECT " +
                $"{TableName.orders}.Id, " +
                $"{TableName.cares}.Name as 'Услуга', " +
                $"concat({TableName.employees}.FirstName, ' ', {TableName.employees}.SurnName) as 'Сотрудник', " +
                $"concat({TableName.clients}.FirstName, ' ', {TableName.clients}.SurnName) as 'Клиент', " +
                $"IdClient, " +
                $"IdEmployee, " +
                $"IdCare, " +
                $"DateOrder as 'Дата заказа', " +
                $"StartTime as 'Начало', " +
                $"EndTime as 'Конец', " +
                $"Status as 'Статус' " +
                $"FROM {bdName}.{TableName.orders} " +
                $"LEFT JOIN {bdName}.{TableName.clients} ON {TableName.orders}.IdClient = {TableName.clients}.Id " +
                $"LEFT JOIN {bdName}.{TableName.employees} ON {TableName.orders}.IdEmployee  = {TableName.employees}.Id " +
                $"LEFT JOIN {bdName}.{TableName.cares} ON {TableName.orders}.IdCare = {TableName.cares}.Id ;";
            return sql;
        }

        public string getTableFilteredData(string searchStr)
        {
            string selectSql = getTableData();
            selectSql = selectSql.Remove(selectSql.Length - 1, 1);
            string filteredSql = $"WHERE " +
                $"{TableName.cares}.Name LIKE '%{searchStr}%' " +
                $"OR {TableName.employees}.FirstName LIKE '%{searchStr}%' " +
                $"OR {TableName.employees}.SurnName LIKE '%{searchStr}%'" +
                $"OR {TableName.clients}.FirstName LIKE '%{searchStr}%'" +
                $"OR {TableName.clients}.SurnName LIKE '%{searchStr}%'" +
                $"OR DateOrder LIKE '%{searchStr}%' ;";
            return selectSql + " " + filteredSql;
        }

        public string addRow(OrderItem orderItem)
        {
            string sql = $"INSERT INTO {bdName}.{TableName.orders} (IdClient, IdEmployee, IdCare, DateOrder, StartTime, EndTime, Status) " +
                $"VALUES(" +
                $"{orderItem.idClient}, " +
                $"{orderItem.idEmployee}, " +
                $"{orderItem.idCare}, " +
                $"'{orderItem.dateOrder:yyyy-MM-dd}', " +
                $"'{orderItem.startTime:HH:mm:ss}', " +
                $"'{orderItem.endTime:HH:mm:ss}', " +
                $"'new');";
            return sql;
        }

        public string editStatus(string id, string status) {
            return $"UPDATE {bdName}.{TableName.orders} SET Status='{status}' WHERE Id={id} ;";
        }
    }
}
