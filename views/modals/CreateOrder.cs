using BeautySaloon.controllers;
using BeautySaloon.models;
using BeautySaloon.models.types;
using BeautySaloon.utils;
using BeautySaloon.views.types;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautySaloon.views.modals
{
    public partial class CreateOrder : Form
    {
        ApiService apiService = new ApiService();        
        Action gridUpdate;
        public CreateOrder(Action gridUpdate)
        {
            InitializeComponent();
            this.gridUpdate = gridUpdate;
            var caresData = (DataTable)apiService.cares.getData().DataSource;
            comboBoxEmployee.Enabled = false;
            setComboboxList(comboBoxCare, caresData, "Id", "Name");
            var clientsData = (DataTable)apiService.clients.getData().DataSource;
            setComboboxList(comboBoxClient, clientsData, "Id", "FullName");
            setEmployeesListBySelectedCare();
        }

        private void setComboboxList(System.Windows.Forms.ComboBox comboBox, 
            DataTable dataTable,
            string keyId,
            string keyText) 
        {
            List<ComboboxItem> listItems = new List<ComboboxItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                listItems.Add(new ComboboxItem
                {
                    id = row[keyId].ToString(),
                    text = row[keyText].ToString()
                });

            }
            comboBox.DataSource = listItems;
        }

        private void setEmployeesListBySelectedCare() {
            var employeeList = (DataTable)apiService.employees.getDataByCareId(
            new models.types.CareItem()
            {
                id = comboBoxCare.SelectedValue.ToString(),
            }).DataSource;
            setComboboxList(comboBoxEmployee, employeeList, "Id", "FullName");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem() {
                idCare = comboBoxCare.SelectedValue.ToString(),
                idEmployee = comboBoxEmployee.SelectedValue.ToString(),
                idClient = comboBoxClient.SelectedValue.ToString(),
                dateOrder  = dateTimePickerDateOrder.Value,
                startTime = dateTimePickerStartTime.Value,
                endTime = dateTimePickerEndTime.Value,
            };
            apiService.orders.addItem(orderItem);
            gridUpdate();
            this.Close();
        }


        private void comboBoxCare_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmployee.Enabled = true;
        }

        private void comboBoxCare_DropDownClosed(object sender, EventArgs e)
        {
            setEmployeesListBySelectedCare();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
