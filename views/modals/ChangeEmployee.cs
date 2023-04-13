using BeautySaloon.controllers;
using BeautySaloon.models.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.views.modals
{
    public partial class ChangeEmployee : Form
    {
        ApiService apiService = new ApiService();
        DataGridViewRow selectedRow;
        public ChangeEmployee(DataGridViewRow selectedRow = null)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            if (selectedRow != null )
            {
                textBoxFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                textBoxSurnName.Text = selectedRow.Cells["SurnName"].Value.ToString();
                textBoxMiddleName.Text = selectedRow.Cells["MiddleName"].Value.ToString();
                textBoxPosition.Text = selectedRow.Cells["Position"].Value.ToString();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            EmployeeItem item = new EmployeeItem();
            item.firstName = textBoxFirstName.Text;
            item.surnName = textBoxSurnName.Text;
            item.middleName = textBoxMiddleName.Text;
            item.position = textBoxPosition.Text;
            if (selectedRow != null)
            {
                item.id = selectedRow.Cells["Id"].Value.ToString();
                apiService.employees.editItem(item);
            }
            else {
                apiService.employees.addItem(item);
            }
            
        }
    }
}
