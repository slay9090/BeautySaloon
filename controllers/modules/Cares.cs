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
    internal class Cares : DBService
    {
        public BindingSource getData()
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.cares.getTableData());
        }
        public void addItem(CareItem careItem)
        {
            string[] requiredElems = {
                careItem.name,
                careItem.price
            };
            Utils.DBAdapter.setBdData(dbConnect, modelService.cares.addRow(careItem), requiredElems);

        }
        public void editItem(CareItem careItem)
        {
            string[] requiredElems = {
                careItem.name,
                careItem.price,
                careItem.id
            };
            Utils.DBAdapter.setBdData(dbConnect,
                modelService.cares.editRow(careItem),
                requiredElems);
        }

        public void deleteItem(CareItem careItem)
        {
            string[] requiredElems = { careItem.id };
            Utils.DBAdapter.setBdData(dbConnect, modelService.cares.deleteRow(careItem), requiredElems);
        }

        public BindingSource getFilteredData(string searchValue)
        {
            return Utils.DBAdapter.getBdData(dbConnect, modelService.cares.getTableFilteredData(searchValue));
        }
    }
}
