using BeautySaloon.models.Types;
using BeautySaloon.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;

namespace BeautySaloon.utils
{
    public static class Utils
    {

        public class Tools {
            public static Boolean isEmptyElemInArray(string[] arr)
            {
                foreach (string el in arr)
                {
                    if (string.IsNullOrEmpty(el)) return true;
                }
                return false;
            }
        }

   

        public class DBAdapter : Tools
        {
            public static void setBdData(MySqlConnection dbConnect, string sqlCommand, string[] requiredFields)
            {

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
            public static dynamic getBdData(MySqlConnection dbConnect, string sqlCommand) {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                try {
                    dataAdapter.SelectCommand = new MySqlCommand(
                        sqlCommand, dbConnect);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;
                    return bSource;
                }     
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return null;
                }                
            }
        }

   




    }
}
