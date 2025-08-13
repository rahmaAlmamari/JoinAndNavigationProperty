using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void DeleteStudent(int id);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void UpdateStudent(Student student);
    }
}