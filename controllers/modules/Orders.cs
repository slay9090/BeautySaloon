using BeautySaloon.models;
using BeautySaloon.models.types;
using BeautySaloon.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BeautySaloon.controllers.modules
{
    internal class Orders : DBService
    {

        public BindingSource getData()
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.orders.getTableData());
        }

        public BindingSource getFilteredData(string searchValue)
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.orders.getTableFilteredData(searchValue));
        }
        public void addItem(OrderItem orderItem) {
            string[] requiredElems = {
                orderItem.idCare,
                orderItem.idClient,
                orderItem.idEmployee,
            };
            Utils.DBAdapter.setBdData(dbConnect, modelService.orders.addRow(orderItem), requiredElems);
        }
        public void editStatus(OrderItem orderItem) {
            string[] requiredElems = {
                orderItem.id,
                orderItem.status,                
            };
            Utils.DBAdapter.setBdData(dbConnect, modelService.orders.editStatus(orderItem.id, orderItem.status), requiredElems);
        }
    }
}
