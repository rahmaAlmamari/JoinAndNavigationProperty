using JoinAndNavigationProperty.Models;
using JoinAndNavigationProperty.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndNavigationProperty
{
    public class ProjectServices
    {
        private readonly DepartmentRepository _departmentRepo;
        private readonly ManagerRepository _managerRepo;
        private readonly CourseRepository _courseRepo;
        private readonly StudentRepository _studentRepo;

        public ProjectServices
            (
            DepartmentRepository departmentRepo,
            ManagerRepository managerRepo,
            CourseRepository courseRepo,
            StudentRepository studentRepo
            )
        {
            _departmentRepo = departmentRepo;
            _managerRepo = managerRepo;
            _courseRepo = courseRepo;
            _studentRepo = studentRepo;
        }

        //to add data to the database ...
        public void CreateSampleData()
        {
            // ===== DEPARTMENTS =====
            if (!_departmentRepo.GetAllDepartments().Any())
            {
                var departments = new List<Department>
            {
                new Department { DepartmentName = "Computer Science" },
                new Department { DepartmentName = "Mathematics" },
                new Department { DepartmentName = "Physics" },
                new Department { DepartmentName = "Chemistry" }
            };
                foreach (var d in departments) _departmentRepo.AddDepartment(d);
            }

            // ===== MANAGERS =====
            if (!_managerRepo.GetAllManagers().Any())
            {
                var managers = new List<Manager>
            {
                new Manager { ManagerName = "Alice", DepartmentId = 1 },
                new Manager { ManagerName = "Bob", DepartmentId = 2 },
                new Manager { ManagerName = "Charlie", DepartmentId = 3 },
                new Manager { ManagerName = "Diana", DepartmentId = 4 }
            };
                foreach (var m in managers) _managerRepo.AddManager(m);
            }

            // ===== COURSES =====
            if (!_courseRepo.GetAllCourses().Any())
            {
                var courses = new List<Course>
            {
                new Course { CourseName = "Algorithms" },
                new Course { CourseName = "Data Structures" },
                new Course { CourseName = "Linear Algebra" },
                new Course { CourseName = "Quantum Mechanics" },
                new Course { CourseName = "Organic Chemistry" }
            };
                foreach (var c in courses) _courseRepo.AddCourse(c);
            }

            // ===== STUDENTS =====
            if (!_studentRepo.GetAllStudents().Any())
            {
                var students = new List<Student>
            {
                new Student {
                    StudentName = "John",
                    StudentMark = 85,
                    DepartmentId = 1,
                    courses = new List<Course>
                    {
                        _courseRepo.GetCourseById(1),
                        _courseRepo.GetCourseById(2)
                    }
                },
                new Student {
                    StudentName = "Emma",
                    StudentMark = 92,
                    DepartmentId = 1,
                    courses = new List<Course>
                    {
                        _courseRepo.GetCourseById(1)
                    }
                },
                new Student {
                    StudentName = "Michael",
                    StudentMark = 76,
                    DepartmentId = 2,
                    courses = new List<Course>
                    {
                        _courseRepo.GetCourseById(3)
                    }
                },
                new Student {
                    StudentName = "Sophia",
                    StudentMark = 88,
                    DepartmentId = 3,
                    courses = new List<Course>
                    {
                        _courseRepo.GetCourseById(4)
                    }
                },
                new Student {
                    StudentName = "Daniel",
                    StudentMark = 79,
                    DepartmentId = 4,
                    courses = new List<Course>
                    {
                        _courseRepo.GetCourseById(5)
                    }
                }
            };

                foreach (var s in students) _studentRepo.AddStudent(s);
            }
        }

      

    }
}
