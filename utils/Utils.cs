using BeautySaloon.models.Types;
using BeautySaloon.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon.utils
{
    public static class Utils
    {

        public static Boolean isEmptyElemInArray(string[] arr)
        {
            foreach (string el in arr)
            {
                if (string.IsNullOrEmpty(el)) return true;
            }
            return false;
        }

        public static void addItem(MySqlConnection dbConnect, string sqlCommand, string[] requiredFields) {
            
            if (!isEmptyElemInArray(requiredFields))
            {
                try
                {
                    var cmd = dbConnect.CreateCommand();
                    cmd.CommandText = sqlCommand;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Заполнены не все поля!");
            }

        }
    

    }
}
