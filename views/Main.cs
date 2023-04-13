using BeautySaloon.controllers;
using BeautySaloon.controllers.modules;
using BeautySaloon.models.Types;
using BeautySaloon.views.modals;
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

            getEmployeesData();


        }

 

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            ChangeEmployee changeEmployee = new ChangeEmployee(getEmployeesData);
 
             changeEmployee.Show();
        }

        private void buttonChangeEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
                ChangeEmployee changeEmployee = new ChangeEmployee(getEmployeesData,selectedRow);
                changeEmployee.Show();
                Console.WriteLine("?");
            }
            else {
                MessageBox.Show("ничего не выбранно");
               
            }
               
        }

        public void getEmployeesData() {
            dataGridViewEmployee.DataSource = apiService.employees.getData();
            tableEmployeeSetView(dataGridViewEmployee);

        }



        private void tableEmployeeSetView(DataGridView dataGrid)
        {
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].HeaderText = "Отчество";
            dataGrid.Columns["Position"].HeaderText = "Должность";
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
                EmployeeItem employeeItem = new EmployeeItem();
                employeeItem.id = selectedRow.Cells["Id"].Value.ToString();
                apiService.employees.deleteItem(employeeItem);
                getEmployeesData();
            }
            else
            {
                MessageBox.Show("ничего не выбранно");

            }
        }

        private void buttonFilteredItems_Click(object sender, EventArgs e)
        {
            var data = apiService.employees.getFilteredData(textBoxFiltered.Text);
            dataGridViewEmployee.DataSource = data;
            tableEmployeeSetView(dataGridViewEmployee);
        }

        private void buttonFilteredItems_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            getEmployeesData();
        }
    }
}
