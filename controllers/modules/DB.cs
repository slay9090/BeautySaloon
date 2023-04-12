using BeautySaloon.models;
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
            dataAdapter.SelectCommand = new MySqlCommand(modelService.db.create(), dbConnect);
        }
    }
}
