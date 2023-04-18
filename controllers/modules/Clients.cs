using BeautySaloon.models.types;
using BeautySaloon.models.Types;
using BeautySaloon.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.controllers.modules
{
    internal class Clients : DBService
    {
        public BindingSource getData()
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.clients.getTableData());
        }
        public void addItem(ClientItem clientsItem)
        {
            string[] requiredElems = {
                clientsItem.firstName,
                clientsItem.surnName,
                clientsItem.phoneNumber,
                clientsItem.birthDate
            };
            Utils.DBAdapter.setBdData(dbConnect, modelService.clients.addRow(clientsItem), requiredElems);

        }
        public void editItem(ClientItem clientsItem)
        {

            string[] requiredElems = {
                clientsItem.firstName,
                clientsItem.surnName,
                clientsItem.phoneNumber,
                clientsItem.birthDate,
                clientsItem.id
            };
            Utils.DBAdapter.setBdData(dbConnect,
                modelService.clients.editRow(clientsItem),
                requiredElems);
        }

        public void deleteItem(ClientItem clientsItem)
        {
            string[] requiredElems = { clientsItem.id };
            Utils.DBAdapter.setBdData(dbConnect, modelService.clients.deleteRow(clientsItem), requiredElems);
        }

        public BindingSource getFilteredData(string searchValue)
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.clients.getTableFilteredData(searchValue));
        }
    }
}
