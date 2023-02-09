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
            this.students = new Dictionary<int, User>()
            {
                {
                    1, new User{UserId = 1,
                             Name = "Aslbek",
                             Birthday = DateTime.Parse("2004-04-07"),
                             Gender = Gender.Male,
                             UserType = UserType.Student
                            }
                },
                {
                    2, new User{UserId = 2,
                             Name = "Aziza",
                             Birthday = DateTime.Parse("2000-08-07"),
                             Gender = Gender.Female,
                             UserType = UserType.Student
                           }
                },
                {
                    3, new User{UserId = 3,
                             Name = "Shahzod",
                             Birthday = DateTime.Parse("2003-05-15"),
                             Gender = Gender.Male,
                             UserType = UserType.Student
                           }
                }
            };
    
        }
        public List<User> SelectAllStudents()=>
        students.Values.ToList();
        public User SelectStudentById(int studentId)
        {
            if(!students.ContainsKey(studentId))
                throw new KeyNotFoundException("student not found");
            return students[studentId];
        }                                  
        public User InsertStudent(User student)
        {
            if(students.ContainsKey(student.UserId))
                throw new ArgumentException("Student with this key already exits");
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
            
            existingStudent.Birthday = student.Birthday;
    
            existingStudent.UserId = student.UserId;
            
            existingStudent.Gender = student.Gender;
        
            
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