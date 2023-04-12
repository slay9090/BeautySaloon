using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.controllers
{
    class ConnectInfo
    {
        public string user;
        public string password;
        public string server;
        public string port;
        public string DBName;

        public ConnectInfo(string _user, string _password, string _server, string _port, string _dBName)
        {
            user = _user;
            password = _password;
            server = _server;
            port = _port;
            DBName = _dBName;
        }
    }
}
