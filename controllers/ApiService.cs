using BeautySaloon.controllers.modules;
using BeautySaloon.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.controllers
{
    internal class ApiService
    {
        public modules.Employees employees;
        public modules.DB db;

        public ApiService() {
        employees = new modules.Employees();
        db = new modules.DB();
        
        }
    }
}
