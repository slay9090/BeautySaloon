using BeautySaloon.controllers.modules;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models
{
    internal class Skills : Model
    {
        
        public string getSkillsIdsByEmployeeId(string idEmployee) {
            string sql = $"SELECT IdCare FROM {bdName}.{TableName.skills} WHERE IdEmployee={idEmployee};";
            return sql;
        }

        public string addSkillsByEmployeeId(List<string> skills, string id) {            
            string sql = $"INSERT INTO {bdName}.{TableName.skills} (IdEmployee, IdCare) " +
                $"VALUES {buildValuesToInsert(skills, id)};";
            return sql;          
        }

        public string deleteSkillsByEmployeeId(string id) {
            string sql = $"DELETE FROM {bdName}.{TableName.skills} WHERE IdEmployee={id};";
            return sql;
        }

        private string buildValuesToInsert(List<string> skills, string id) {
            List<string> skillsList = new List<string>();
            foreach (string skill in skills)
            {
                skillsList.Add($"({id}, {skill}),");
            }
            string result = String.Join(" ",skillsList);
            return result.Remove(result.Length - 1, 1);

        }
    }
}
