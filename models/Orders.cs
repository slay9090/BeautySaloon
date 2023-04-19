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
    }
}
