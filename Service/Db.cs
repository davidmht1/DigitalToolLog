using DigitalToolLog.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace DigitalToolLog.Service
{
    public class Db
    {
        private static Db service;
        private DatabaseContext db;

        private Db()
        {
            db = new DatabaseContext();
        }

        public static Db Service()
        {
            if (service == null)
            {
                service = new Db();
            }
            return service;
        }
        public void Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public void Add(Toolbox toolbox)
        {
            db.Toolboxes.Add(toolbox);
            db.SaveChanges();
        }

        public List<Toolbox> GetToolboxes()
        {
            return db.Toolboxes.ToList();
        }

        public void Add(ToolLog toolLog)
        {
            db.ToolLog.Add(toolLog);
            db.SaveChanges();
        }

        public List<ToolLog> GetToolLog() 
        {
            return db.ToolLog.ToList();        
        }
    }
}
