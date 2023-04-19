namespace BeautySaloon.models
{
    class ModelService : Model
    {
        public DB db;
        public Employees employees;
        public Cares cares;
        public Skills skills;
        public Clients clients;
        public Orders orders;
        public ModelService() {
            db = new DB();
            employees = new Employees();
            cares = new Cares();
            skills = new Skills();
            clients = new Clients();
            orders = new Orders();
        }
        public void setBdName(string name) {
            bdName = name;
        }
    }
}
