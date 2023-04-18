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
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].HeaderText = "Отчество";
            dataGrid.Columns["Position"].HeaderText = "Должность";
        }

        private void updatedCaresData()
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

        private void updatedSkillsEmployeeData() {
            dataGridViewSkills.DataSource = apiService.employees.getData();
            tableSkillsEmployeeSetView(dataGridViewSkills);
        }

        private void tableSkillsEmployeeSetView(DataGridView dataGrid) {
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["FirstName"].HeaderText = "Фамилия";
            dataGrid.Columns["SurnName"].HeaderText = "Имя";
            dataGrid.Columns["MiddleName"].Visible = false;
            dataGrid.Columns["Position"].Visible = false;
        }

        private void updatedCheckedSkillsByEmployee() {

            DataGridViewRow selectedRow = dataGridViewSkills.SelectedRows[0];
            string idEmployee = selectedRow.Cells["Id"].Value.ToString();
            Console.WriteLine("idEmployee" + idEmployee);
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




        /// <summary>
        /// --- то что дальше вынести их в partial ---
        /// </summary>



     

        private void btnGetData_Click(object sender, EventArgs e)
        {          
           //getEmployeesData();
            
           
        }

 

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            ChangeEmployee changeEmployee = new ChangeEmployee(updatedEmployeesData); 
            changeEmployee.Show();
        }

        private void buttonChangeEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
                ChangeEmployee changeEmployee = new ChangeEmployee(updatedEmployeesData, selectedRow);
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
                updatedEmployeesData();
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
            updatedEmployeesData();
            updatedCaresData();
            updatedSkillsEmployeeData();

            checkedListBoxSkills.DataSource = apiService.cares.getData();
            checkedListBoxSkills.DisplayMember = "Name";

            
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {


            //setCheckedSkillsByEmployee();

            Console.WriteLine(e.TabPage);
            Console.WriteLine(tabPageSkills);
            if (e.TabPage == tabPageSkills) {
                dataGridViewSkills.Rows[0].Selected = true;
                updatedCheckedSkillsByEmployee();
            }


        }



        private void buttonCareAddItem_Click(object sender, EventArgs e)
        {
            ChangeCare changeCare = new ChangeCare(updatedCaresData);
            changeCare.Show();

        }

        private void buttonCareEditItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCares.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridViewCares.SelectedRows[0];
                ChangeCare changeCare = new ChangeCare(updatedCaresData, selectedRow);
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
                updatedCaresData();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
             
                //getCaresData();
            }
            else
            {
                MessageBox.Show("ничего не выбранно");
            }
        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {
      
        }

        private void tabPageSkills_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewSkills_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridViewSkills.Rows[e.RowIndex];
            //string idEmployee = row.Cells["Id"].Value.ToString();
            updatedCheckedSkillsByEmployee();
        }
    }
}
