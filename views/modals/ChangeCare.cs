using BeautySaloon.controllers;
using BeautySaloon.models.types;
using System;
using System.Windows.Forms;

namespace BeautySaloon.views.modals
{
    public partial class ChangeCare : Form
    {
        ApiService apiService = new ApiService();
        DataGridViewRow editedRow;
        Action gridUpdate;
        public ChangeCare(Action gridUpdate, DataGridViewRow selectedRow = null)
        {
            InitializeComponent();
            this.editedRow = selectedRow;
            this.gridUpdate = gridUpdate;
            if (editedRow != null)
            {
                textBoxName.Text = editedRow.Cells["Name"].Value.ToString();
                textBoxPrice.Text = editedRow.Cells["Price"].Value.ToString();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            CareItem item = new CareItem
            {
                name = textBoxName.Text,
                price = textBoxPrice.Text
            };

            if (!int.TryParse(item.price, out _) || int.Parse(item.price) <= 0) {
                MessageBox.Show("Некорректная стоимость");
                return;
            }

            if (editedRow != null)
            {
                item.id = editedRow.Cells["Id"].Value.ToString();
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
