using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using BeautySaloon.models;
using System.Data;

namespace BeautySaloon.controllers
{
    class DBService
    {
        public MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        public ModelService modelService = new ModelService();
        public static MySqlConnection dbConnect;
        ApiService apiService;

         public Boolean init(ConnectInfo connectInfo) {            

            string connectionString = 
                $"SERVER={connectInfo.server};" +
                $"PORT={connectInfo.port};" +
                $"UID={connectInfo.user};" +
                $"PASSWORD={connectInfo.password};";
            dbConnect = new MySqlConnection(connectionString);
            try
            {
                dbConnect.Open();
                apiService = new ApiService();
                
                modelService.setBdName(connectInfo.DBName);
                //model.bdName = connectInfo.DBName;
                apiService.db.create();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! "+ex+"");
                dbConnect.Close();
                return false;
            }
        }

    }
}
