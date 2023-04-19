using BeautySaloon.models;
using BeautySaloon.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.controllers.modules
{
    internal class Orders : DBService
    {

        public BindingSource getData()
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.orders.getTableData());
        }
    }
}
