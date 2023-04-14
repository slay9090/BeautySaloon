using BeautySaloon.controllers;
using BeautySaloon.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySaloon
{
    public partial class Auth : Form
    {

        DBService dbService = new DBService();
        private Main mainForm = new Main();


        public Auth()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ADASDASASDDS");
            ConnectInfo connectInfo = new ConnectInfo(
                textBoxUserName.Text, 
                textBoxPassword.Text, 
                textBoxServer.Text, 
                textBoxPort.Text,
                textBoxDbName.Text
                );
           Boolean isConnect = dbService.init(connectInfo);
            Console.WriteLine(isConnect);
            if ( isConnect )
            {                
                this.Hide();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }

        }
    }
}
