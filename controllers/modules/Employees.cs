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

namespace BeautySaloon.controllers.modules
{
    internal class Employees : DBService
    {
        //public MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        //private Model model = new Model();

        public Employees() {              
        }
        public BindingSource getData()
        {
            Console.WriteLine("da nu" + dbConnect.State);
            dataAdapter.SelectCommand = new MySqlCommand(modelService.employees.getTableData(), dbConnect);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }
    }
}
