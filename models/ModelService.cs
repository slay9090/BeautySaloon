using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.models
{
    class ModelService : Model
    {
        public DB db;
        public Employees employees;
        public ModelService() {
            db = new DB();
            employees = new Employees();
        }
        public void setBdName(string name) {
            bdName = name;
        }
    }
}
