using BeautySaloon.controllers;
using BeautySaloon.models.types;
using System;
using System.Windows.Forms;

namespace BeautySaloon.views.modals
{
    public partial class ChangeClient : Form
    {
        ApiService apiService = new ApiService();
        DataGridViewRow editedRow;
        Action gridUpdate;
        public ChangeClient(Action gridUpdate, DataGridViewRow selectedRow = null)
        {
            InitializeComponent();
            this.editedRow = selectedRow;
            this.gridUpdate = gridUpdate;
            if (editedRow != null)
            {
                textBoxFirstName.Text = editedRow.Cells["FirstName"].Value.ToString();
                textBoxSurnName.Text = editedRow.Cells["SurnName"].Value.ToString();
                textBoxMiddleName.Text = editedRow.Cells["MiddleName"].Value.ToString();
                textBoxPhoneNumber.Text = editedRow.Cells["PhoneNumber"].Value.ToString();
                dateTimePickerBirthName.Text = editedRow.Cells["BirthDate"].Value.ToString();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClientItem item = new ClientItem
            {
                firstName = textBoxFirstName.Text,
                surnName = textBoxSurnName.Text,
                middleName = textBoxMiddleName.Text,
                phoneNumber = textBoxPhoneNumber.Text,
                birthDate = dateTimePickerBirthName.Value
            };

            if (editedRow != null)
            {
                item.id = editedRow.Cells["Id"].Value.ToString();
                apiService.clients.editItem(item);
            }
            else
            {
                apiService.clients.addItem(item);
            }
            gridUpdate();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
