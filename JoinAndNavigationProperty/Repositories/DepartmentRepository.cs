using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public class DepartmentRepository
    {
        private readonly RDbContext _context;
        public DepartmentRepository(RDbContext context)
        {
            _context = context;
        }
        //to Get All Departments ...
        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }
        //to Get Department By Id ...
        public Department GetDepartmentById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.DepartmentId == id);
        }
        //to Add Department ...
        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }
        //to Update Department ...
        public void UpdateDepartment(Department department)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == department.DepartmentId);
            if (existingDepartment != null)
            {
                existingDepartment.DepartmentName = department.DepartmentName;
                _context.SaveChanges();
            }
        }
        //to Delete Department ...
        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }
    }
}
