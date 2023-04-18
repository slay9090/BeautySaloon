using BeautySaloon.controllers;
using BeautySaloon.models.types;
using System;
using System.Windows.Forms;

namespace BeautySaloon.views.modals
{
    public partial class ChangeClient : Form
    {
        ApiService apiService = new ApiService();
        DataGridViewRow selectedRow;
        Action gridUpdate;
        public ChangeClient(Action gridUpdate, DataGridViewRow selectedRow = null)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.gridUpdate = gridUpdate;
            if (selectedRow != null)
            {
                /*textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                textBoxPrice.Text = selectedRow.Cells["Price"].Value.ToString();*/

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            CareItem item = new CareItem();
     /*       item.name = textBoxName.Text;
            item.price = textBoxPrice.Text;*/


            if (selectedRow != null)
            {
                item.id = selectedRow.Cells["Id"].Value.ToString();
                apiService.cares.editItem(item);
            }
            else
            {
                apiService.cares.addItem(item);
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
