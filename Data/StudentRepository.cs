using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Data
{
    public class StudentRepository : IStudentRepository
    {
        private Dictionary<int, User> students;
        public StudentRepository()
        {
            this.students = new Dictionary<int, User>();
        }
        public List<User> SelectAllStudents()=>
        students.Values.ToList();
        public User SelectStudentById(int studentId)
        {
            if(students.ContainsKey(studentId))
                throw new KeyNotFoundException("student not found");
            return students[studentId];
        }                                  
        public User InsertStudent(User student)
        {
            if(!students.ContainsKey(student.UserId))
                throw new ArgumentException("Students with this key already exits");
            students.Add(student.UserId, student);
            return student;
        }
        public User UpdateStudent(int studentId, User student)
        {
            if(!students.ContainsKey(studentId))
                throw new KeyNotFoundException("Student not found");
            var existingStudent = students[studentId];
            if(!string.IsNullOrEmpty(student.Name))
                existingStudent.Name = student.Name;
            return existingStudent;     
        }
        public bool DeleteStudent(int studentId)
        {
            if(!students.ContainsKey(studentId))
                throw new KeyNotFoundException("student not found");
            return students.Remove(studentId);
        }
        
    }
}