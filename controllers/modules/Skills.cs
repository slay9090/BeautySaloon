using BeautySaloon.models;
using BeautySaloon.models.types;
using BeautySaloon.utils;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.controllers.modules
{
    internal class Skills : DBService
    {
        public void deleteCaresByEmployeeId(string employeeId) {
            string[] requiredElems = { employeeId };
            Utils.DBAdapter.setBdData(dbConnect, modelService.skills.deleteSkillsByEmployeeId(employeeId), requiredElems);
        }

        public void addCaresByEmployeeId(List<string> skills, string id) {
            string[] requiredElems = { id };
            if (!skills.Any()) { return; }           
            Utils.DBAdapter.setBdData(dbConnect, modelService.skills.addSkillsByEmployeeId(skills, id), requiredElems);
        }
        public List<string> getCaresIdsByEmployeeId(string employeeId) {
            List<string> ids = new List<string>();
            BindingSource bs = Utils.DBAdapter.getBdData(dbConnect, modelService.skills.getSkillsIdsByEmployeeId(employeeId));
            DataTable dt = (DataTable)bs.DataSource;
            foreach (DataRow row in dt.Rows)
            {
                ids.Add(row["IdCare"].ToString());                
            }
            return ids;            
        }
    }
}
