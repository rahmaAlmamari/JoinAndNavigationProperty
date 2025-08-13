using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public interface ICourseRepository
    {
        void AddCourse(Course course);
        void DeleteCourse(int id);
        List<Course> GetAllCourses();
        Course GetCourseById(int id);
        void UpdateCourse(int id);
    }
}