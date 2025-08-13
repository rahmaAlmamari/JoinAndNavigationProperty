using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly RDbContext _context;
        public ManagerRepository(RDbContext context)
        {
            _context = context;
        }
        //to get all managers ...
        public List<Manager> GetAllManagers()
        {
            return _context.Managers.ToList();
        }
        //to get manager by id ...
        public Manager GetManagerById(int id)
        {
            return _context.Managers.FirstOrDefault(m => m.ManagerId == id);
        }
        //to add manager ...
        public void AddManager(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
        }
        //to update manager ...
        public void Updater(Manager manager)
        {
            var existingManager = _context.Managers.FirstOrDefault(m => m.ManagerId == manager.ManagerId);
            if (existingManager != null)
            {
                existingManager.ManagerName = manager.ManagerName;
                existingManager.department = manager.department;
                _context.SaveChanges();
            }

        }
        //to delete manager ...
        public void DeleteManager(int id)
        {
            var manager = _context.Managers.FirstOrDefault(m => m.ManagerId == id);
            if (manager != null)
            {
                _context.Managers.Remove(manager);
                _context.SaveChanges();
            }
        }
    }
}
