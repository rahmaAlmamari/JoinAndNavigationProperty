using JoinAndNavigationProperty.Repositories;
using JoinAndNavigationProperty.Models;
using Microsoft.EntityFrameworkCore;


namespace JoinAndNavigationProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RDbContext _context = new RDbContext();
            CourseRepository _CourseRepository = new CourseRepository(_context);
            ManagerRepository _ManagerRepository = new ManagerRepository(_context);
            DepartmentRepository _DepartmentRepository = new DepartmentRepository(_context);
            StudentRepository _StudentRepository = new StudentRepository(_context);
            ProjectServices _projectServices = new ProjectServices(
                _DepartmentRepository,
                _ManagerRepository,
                _CourseRepository,
                _StudentRepository
            );

            //to run the CreateSampleData method to populate the database with sample data ...
            //_projectServices.CreateSampleData();

            // var students = _context.Students
            //.Where(s => s.department.DepartmentName == "Physics")
            //.ToList(); // Runs in DB

            // if (students.Count == 0)
            // {
            //     Console.WriteLine("No students found in the Physics department.");
            //     return;
            // }
            // else
            // {
            //     foreach (var student in students)
            //     {
            //         Console.WriteLine($"Student Name: {student.StudentName}, Department: {student.department.DepartmentName}");
            //     }
            // }

            // Console.WriteLine("press any key to exit...");
            // Console.ReadKey();





            //================================================================


            // var students = _context.Students.Include(s => s.department) // Eager loading the department
            //.Where(s => s.department.DepartmentName == "Physics")
            //.ToList(); // Runs in DB

            // if (students.Count == 0)
            // {
            //     Console.WriteLine("No students found in the Physics department.");
            //     return;
            // }
            // else
            // {
            //     foreach (var student in students)
            //     {
            //         Console.WriteLine($"Student Name: {student.StudentName}, Department: {student.department.DepartmentName}");
            //     }
            // }

            // Console.WriteLine("press any key to exit...");
            // Console.ReadKey();


        }
    }
}
