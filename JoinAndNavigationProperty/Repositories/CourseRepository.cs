using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public class CourseRepository
    {
        private readonly RDbContext _context;
        public CourseRepository(RDbContext context)
        {
            _context = context;
        }
        //to get all courses ...
        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }
        //to get course by id ...
        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.CourseId == id);
        }
        //to add course ...
        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
        //to update course ...
        public void UpdateCourse(int id)
        {
            var existingCourse = _context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (existingCourse != null)
            {
                // Update properties as needed
                _context.SaveChanges();
            }
        }
        //to delete course ...
        public void DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}
