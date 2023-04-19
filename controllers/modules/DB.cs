using BeautySaloon.models;
using BeautySaloon.models.types;
using BeautySaloon.models.Types;
using BeautySaloon.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.controllers.modules
{
    internal class DB : DBService
    {
        public void create() {
            Utils.DBAdapter.setBdData(dbConnect, modelService.db.create());
        }
        public void drop() { 
            Utils.DBAdapter.setBdData(dbConnect, modelService.db.removeTables());
        }
        public void createShema() {         
            Utils.DBAdapter.setBdData(dbConnect, ClientItem.schema);
            Utils.DBAdapter.setBdData(dbConnect, EmployeeItem.schema);
            Utils.DBAdapter.setBdData(dbConnect, CareItem.schema);
            Utils.DBAdapter.setBdData(dbConnect, SkillItem.schema);
            Utils.DBAdapter.setBdData(dbConnect, OrderItem.schema);   
        }

        public void generateData() {
            Utils.DBAdapter.setBdData(dbConnect, modelService.db.generateFakeData());
        }
    }
}
