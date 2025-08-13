using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly RDbContext _context;
        public StudentRepository(RDbContext context)
        {
            _context = context;
        }
        //to Get All Students ...
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
        //to Get Student By Id ...
        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }
        //to Add Student ...
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        //to Update Student ...
        public void UpdateStudent(Student student)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existingStudent != null)
            {
                existingStudent.StudentName = student.StudentName;
                existingStudent.StudentMark = student.StudentMark;
                existingStudent.DepartmentId = student.DepartmentId;
                _context.SaveChanges();
            }
        }
        //to Delete Student ...
        public void DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
