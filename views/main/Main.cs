using BeautySaloon.controllers;
using BeautySaloon.controllers.modules;
using BeautySaloon.models.types;
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

namespace BeautySaloon.views
{
    public partial class Main : Form
    {        
        ApiService apiService;       
        public Main()
        {
            InitializeComponent();
            apiService = new ApiService();       
            
        }

        /// <summary>
        /// то что дальше вынести их в partial
        /// </summary>
        public void getEmployeesData()
        {
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

        private void getCaresData()
        {
            dataGridViewCares.DataSource = apiService.cares.getData();
            tableCaresSetView(dataGridViewCares);
        }
        private void tableCaresSetView(DataGridView dataGrid)
        {
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["Name"].HeaderText = "Название";
            dataGrid.Columns["Price"].HeaderText = "Стоимость";
        }




        /// <summary>
        /// то что дальше вынести их в partial
        /// </summary>



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
                
            }
            else {
                MessageBox.Show("ничего не выбранно");               
            }
               
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

   
        private void Main_Load(object sender, EventArgs e)
        {
            getEmployeesData();
            getCaresData();
        }



        private void buttonCareAddItem_Click(object sender, EventArgs e)
        {
            ChangeCare changeCare = new ChangeCare(getCaresData);
            changeCare.Show();

        }

        private void buttonCareEditItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCares.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewCares.SelectedRows[0];
                ChangeCare changeCare = new ChangeCare(getCaresData, selectedRow);
                changeCare.Show();

            }
            else
            {
                MessageBox.Show("ничего не выбранно");
            }
        }

        private void buttonCareDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCares.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewCares.SelectedRows[0];
                CareItem careItem = new CareItem();
                careItem.id = selectedRow.Cells["Id"].Value.ToString();
                apiService.cares.deleteItem(careItem);
                getCaresData();
            }
            else
            {
                MessageBox.Show("ничего не выбранно");

            }
        }

        private void buttonCareSearch_Click(object sender, EventArgs e)
        {
            var data = apiService.cares.getFilteredData(textBoxCareSearch.Text);
            dataGridViewCares.DataSource = data;
            tableCaresSetView(dataGridViewCares);
        }
    }
}
