using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public interface IDepartmentRepository
    {
        void AddDepartment(Department department);
        void DeleteDepartment(int id);
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        void UpdateDepartment(Department department);
    }
}