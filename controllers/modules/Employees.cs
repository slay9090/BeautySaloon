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

        public Employees() {              
        }
        public BindingSource getData()
        {            
            dataAdapter.SelectCommand = new MySqlCommand(modelService.employees.getTableData(), dbConnect);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }
        public void addItem(EmployeeItem employeeItem) {
            string[] requiredElems = { 
                employeeItem.firstName, 
                employeeItem.surnName, 
                employeeItem.position 
            };
            Utils.addItem(dbConnect, modelService.employees.addRow(employeeItem), requiredElems);
        }
        public void editItem(EmployeeItem employeeItem) {
            Console.WriteLine("edit" + employeeItem.id);
        }
    }
}
