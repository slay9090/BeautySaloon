using BeautySaloon.controllers;
using BeautySaloon.controllers.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.view
{
    public partial class Main : Form
    {
        //Employees apiService;
        ApiService apiService;
        public Main()
        {
            InitializeComponent();
            apiService = new ApiService();
  

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine("select");
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            dataGridViewEmployee.DataSource = apiService.employees.getData();
            tableEmployeeSetView(dataGridViewEmployee);
     
        }

        private void tableEmployeeSetView(DataGridView dataGrid) {
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].HeaderText = "Отчество";
            dataGrid.Columns["Position"].HeaderText = "Должность";
        }
    }
}
