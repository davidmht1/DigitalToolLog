using DigitalToolLog.Models;
using Microsoft.EntityFrameworkCore;
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

        public void Update(Toolbox toolbox)
        {
            db.Toolboxes.Update(toolbox);
            db.SaveChanges();
        }
        public void Delete(Toolbox toolbox)
        {
            db.Toolboxes.Remove(toolbox);
            db.SaveChanges();
        }
        public List<Toolbox> GetToolboxes()
        {
            return db.Toolboxes.ToList();
        }

        public List<Toolbox> AvailableToolboxes()
        {
            return db.Toolboxes.Where(t => t.IsCheckedOut == false).ToList();
        }

        public void Add(ToolLog toolLog)
        {
            db.ToolLog.Add(toolLog);
            db.SaveChanges();
        }
        public void Update(ToolLog toolLog)
        {
            db.ToolLog.Update(toolLog);
            db.SaveChanges();
        }
        public void Delete(ToolLog toolLog)
        {
            db.ToolLog.Remove(toolLog);
            db.SaveChanges();
        }
        public List<ToolLog> GetToolLog()
        {
            return db.ToolLog
                .Include(t => t.Toolbox)
                .ToList();
        }
    }
}
