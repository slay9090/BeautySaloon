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
        DataGridViewRow editedRow;
        Action gridUpdate;
        public ChangeEmployee( Action gridUpdate, DataGridViewRow selectedRow = null)
        {
            InitializeComponent();
            this.editedRow = selectedRow;
            this.gridUpdate = gridUpdate;
            if (editedRow != null )
            {
                textBoxFirstName.Text = editedRow.Cells["FirstName"].Value.ToString();
                textBoxSurnName.Text = editedRow.Cells["SurnName"].Value.ToString();
                textBoxMiddleName.Text = editedRow.Cells["MiddleName"].Value.ToString();
                textBoxPosition.Text = editedRow.Cells["Position"].Value.ToString();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            EmployeeItem item = new EmployeeItem
            {
                firstName = textBoxFirstName.Text,
                surnName = textBoxSurnName.Text,
                middleName = textBoxMiddleName.Text,
                position = textBoxPosition.Text
            };
            if (editedRow != null)
            {
                item.id = editedRow.Cells["Id"].Value.ToString();
                apiService.employees.editItem(item);
            }
            else {
                apiService.employees.addItem(item);
            }
            gridUpdate();
            this.Close();
            
        }
    }
}
