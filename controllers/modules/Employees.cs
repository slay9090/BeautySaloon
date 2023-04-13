using BeautySaloon.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloon.models.Types;
using BeautySaloon.utils;

namespace BeautySaloon.controllers.modules
{
    internal class Employees : DBService
    {
        public BindingSource getData()
        {
           return Utils.DBAdapter.getBdData(dbConnect, modelService.employees.getTableData());
        }
        public void addItem(EmployeeItem employeeItem) {
            string[] requiredElems = { 
                employeeItem.firstName, 
                employeeItem.surnName, 
                employeeItem.position 
            };
            Utils.DBAdapter.setBdData(dbConnect, modelService.employees.addRow(employeeItem), requiredElems);
            
        }
        public void editItem(EmployeeItem employeeItem) {
            Console.WriteLine("edit" + employeeItem.id);
            string[] requiredElems = {
                employeeItem.firstName,
                employeeItem.surnName,
                employeeItem.position,
                employeeItem.id
            };
            Utils.DBAdapter.setBdData(dbConnect, 
                modelService.employees.editRow(employeeItem), 
                requiredElems);
        }

        public void deleteItem(EmployeeItem employeeItem)
        {
            string[] requiredElems = {employeeItem.id};
            Utils.DBAdapter.setBdData(dbConnect, modelService.employees.deleteRow(employeeItem), requiredElems);
        }

        public BindingSource getFilteredData(string searchValue) {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.employees.getTableFilteredData(searchValue));
        }
    }
}
