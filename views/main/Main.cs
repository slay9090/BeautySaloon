using BeautySaloon.controllers;
using BeautySaloon.controllers.modules;
using BeautySaloon.models.types;
using BeautySaloon.models.Types;
using BeautySaloon.views.modals;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
        public void updatedEmployeesData()
        {
            dataGridViewEmployee.DataSource = apiService.employees.getData();
            tableEmployeeSetView(dataGridViewEmployee);
        }

        private void tableEmployeeSetView(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count <= 0) return;
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].HeaderText = "Отчество";
            dataGrid.Columns["Position"].HeaderText = "Должность";
        }

        public void updatedClientsData()
        {
            dataGridViewClients.DataSource = apiService.clients.getData();
            tableClientsSetView(dataGridViewClients);
        }

        private void tableClientsSetView(DataGridView dataGrid)
        {
            if(dataGrid.Rows.Count <=0) return;
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FullName"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].HeaderText = "Отчество";
            dataGrid.Columns["PhoneNumber"].HeaderText = "Телефон";
            dataGrid.Columns["BirthDate"].HeaderText = "Дата рождения";
        }

        private void updatedCaresData()
        {
            dataGridViewCares.DataSource = apiService.cares.getData();
            tableCaresSetView(dataGridViewCares);
        }
        private void tableCaresSetView(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count <= 0) return;
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["Name"].HeaderText = "Название";
            dataGrid.Columns["Price"].HeaderText = "Стоимость";
        }

        private void updatedSkillsEmployeeData() {
            dataGridViewSkills.DataSource = apiService.employees.getData();
            tableSkillsEmployeeSetView(dataGridViewSkills);
        }

        private void tableSkillsEmployeeSetView(DataGridView dataGrid) {
            if (dataGrid.Rows.Count <= 0) return;
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].Visible = false;
            dataGrid.Columns["Position"].Visible = false;
        }

        private void updatedCheckedSkillsByEmployee() {

            checkedListBoxSkills.DataSource = apiService.cares.getData();
            checkedListBoxSkills.DisplayMember = "Name";

            DataGridViewRow selectedRow = dataGridViewSkills.SelectedRows[0];
            string idEmployee = selectedRow.Cells["Id"].Value.ToString();
            List<string> ids = apiService.skills.getCaresIdsByEmployeeId(idEmployee);
            for (int i = 0; i < checkedListBoxSkills.Items.Count; i++) {
                DataRowView item = (DataRowView)checkedListBoxSkills.Items[i];                
                DataRow row = (DataRow)item.Row;
                checkedListBoxSkills.SetItemChecked(i, false);
                if (ids.Contains(row["Id"].ToString()))
                {
                    checkedListBoxSkills.SetItemChecked(i, true);
                }
            } 

            
        }

        public void updatedOrdersData()
        {
            dataGridViewOrders.DataSource = apiService.orders.getData();
            tableOrdersSetView(dataGridViewOrders);
        }

        private void tableOrdersSetView(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count <= 0) return;
            dataGrid.Columns["IdClient"].Visible = false;
            dataGrid.Columns["IdEmployee"].Visible = false;
            dataGrid.Columns["IdCare"].Visible = false;             

        }




        /// <summary>
        /// --- то что дальше вынести их в partial ---
        /// </summary>





        private void btnGetData_Click(object sender, EventArgs e)
        { 
            updatedEmployeesData();
            updatedCaresData();
            updatedSkillsEmployeeData();
            updatedClientsData();
            updatedOrdersData();
        }

 

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            ChangeEmployee changeEmployee = new ChangeEmployee(updatedEmployeesData); 
            changeEmployee.Show();
        }

        private void buttonChangeEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
            ChangeEmployee changeEmployee = new ChangeEmployee(updatedEmployeesData, selectedRow);
            changeEmployee.Show();               
        }  

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
            EmployeeItem employeeItem = new EmployeeItem();
            employeeItem.id = selectedRow.Cells["Id"].Value.ToString();
            apiService.employees.deleteItem(employeeItem);
            updatedEmployeesData();
        }

        private void buttonFilteredItems_Click(object sender, EventArgs e)
        {
            var data = apiService.employees.getFilteredData(textBoxFiltered.Text);
            dataGridViewEmployee.DataSource = data;
            tableEmployeeSetView(dataGridViewEmployee);
        }

   
        private void Main_Load(object sender, EventArgs e)
        {
            updatedEmployeesData();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageSkills)
            {
                updatedSkillsEmployeeData();
                dataGridViewSkills.Rows[0].Selected = true;
                updatedCheckedSkillsByEmployee();
            }
            if (e.TabPage == tabPageEmployee)
            {          
                updatedEmployeesData();
            }
            if (e.TabPage == tabPageCares)
            {
                updatedCaresData();
            }
            if (e.TabPage == tabPageClients)
            {
                updatedClientsData();
            }
            if (e.TabPage == tabPageOrders)
            {
                updatedOrdersData();             
 
            }

        }



        private void buttonCareAddItem_Click(object sender, EventArgs e)
        {
            ChangeCare changeCare = new ChangeCare(updatedCaresData);
            changeCare.Show();

        }

        private void buttonCareEditItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCares.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewCares.SelectedRows[0];
            ChangeCare changeCare = new ChangeCare(updatedCaresData, selectedRow);
            changeCare.Show();
        }

        private void buttonCareDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCares.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewCares.SelectedRows[0];
            CareItem careItem = new CareItem();
            careItem.id = selectedRow.Cells["Id"].Value.ToString();
            apiService.cares.deleteItem(careItem);
            updatedCaresData();

        }

        private void buttonCareSearch_Click(object sender, EventArgs e)
        {
            var data = apiService.cares.getFilteredData(textBoxCareSearch.Text);
            dataGridViewCares.DataSource = data;
            tableCaresSetView(dataGridViewCares);
        }

        private void buttonSaveSkills_Click(object sender, EventArgs e)
        {
            if (dataGridViewSkills.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewSkills.SelectedRows[0];                
                string idEmployee = selectedRow.Cells["Id"].Value.ToString();
                List<string> skillsList = new List<string>();
                foreach (object itemChecked in checkedListBoxSkills.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;                    
                    string idCare = castedItem["Id"].ToString();
                    skillsList.Add(idCare);
                }
                try {
                    apiService.skills.deleteCaresByEmployeeId(idEmployee);
                    apiService.skills.addCaresByEmployeeId(skillsList, idEmployee);
                }
                catch(Exception ex) {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("ничего не выбранно");
            }
        }

 

        private void dataGridViewSkills_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridViewSkills.Rows[e.RowIndex];    
            updatedCheckedSkillsByEmployee();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            ChangeClient changeClient = new ChangeClient(updatedClientsData);
            changeClient.Show();
        }

        private void buttonChangeClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            ChangeClient changeClient = new ChangeClient(updatedClientsData, dataGridViewClients.SelectedRows[0]);
            changeClient.Show();      
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            ClientItem clientItem = new ClientItem
            {
                id = dataGridViewClients.SelectedRows[0].Cells["Id"].Value.ToString()
            };
            apiService.clients.deleteItem(clientItem);
            updatedClientsData();   
        }

        private void buttonFilterClients_Click(object sender, EventArgs e)
        {
            var data = apiService.clients.getFilteredData(textBoxFilterClients.Text);
            dataGridViewClients.DataSource = data;
            tableClientsSetView(dataGridViewClients);
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(updatedOrdersData);
            createOrder.Show();
        }

        private void buttonFilterOrders_Click(object sender, EventArgs e)
        {
            var data = apiService.orders.getFilteredData(textBoxOrdersFilter.Text);
            dataGridViewOrders.DataSource = data;
            tableOrdersSetView(dataGridViewOrders);
        }

        private void dataGridViewOrders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {          
            if (dataGridViewOrders.Rows.Count <= 0) { return; }
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {

                if (row.Cells["Статус"].Value.ToString() == "completed")
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }
                if (row.Cells["Статус"].Value.ToString() == "canceled")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        private void buttonSetStatusComplited_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            OrderItem orderItem = new OrderItem
            {
                id = dataGridViewOrders.SelectedRows[0].Cells["Id"].Value.ToString(),
                status = "completed",
            };
            apiService.orders.editStatus(orderItem);
            updatedOrdersData();
        }

        private void buttonSetStatusCanceled_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ничего не выбранно");
                return;
            }
            OrderItem orderItem = new OrderItem
            {
                id = dataGridViewOrders.SelectedRows[0].Cells["Id"].Value.ToString(),
                status = "canceled",
            };
            apiService.orders.editStatus(orderItem);
            updatedOrdersData();
        }

        private void btnGenerateBDData_Click(object sender, EventArgs e)
        {
            try {
                apiService.db.drop();
                apiService.db.createShema();
                apiService.db.generateData();
                updatedEmployeesData();
                updatedCaresData();
                updatedSkillsEmployeeData();
                updatedClientsData();
                updatedOrdersData();
            } 
            catch(Exception ex) {
                MessageBox.Show("Не возможно сгенерировать тестовую базу данных" + ex);
            }
        }
    }
}
