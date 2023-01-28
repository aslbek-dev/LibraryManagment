using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Data;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentRepository studentRepository;
        public StudentService()
        {
            this.studentRepository = 
                new StudentRepository();
        }
        public IList<User> RetrieveStudents(string name = null)
        {
            var students = 
                this.studentRepository.SelectAllStudents();
            if(!string.IsNullOrEmpty(name))
            {    
                var filteredStudents = new List<User>();
                foreach(var student in students)
                    if(student.Name.Contains(name))
                        filteredStudents.Add(student);
                return filteredStudents;
            }
            return students;
        }
        public User RetrieveStudent(int studentId)
        {
            User student = null;
            try
            {
                student = 
                    this.studentRepository.SelectStudentById(studentId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return student;
        }
        public User AddStudent(User student)
        {
            User insertedStudent = null;
            try
           {
                insertedStudent = 
                    this.studentRepository.InsertStudent(student);
           }
           catch(ArgumentException exception)
           {
            Console.WriteLine(exception.Message);
           }
           return insertedStudent;
        }

        public User ModifyStudent(int studentId, User student)
        {
            User modifiedStudent = null;
            try
            {
                modifiedStudent = 
                    this.studentRepository.UpdateStudent(studentId, student);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return modifiedStudent;
        }

        public bool RemoveStudent(int studentId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved = 
                    this.studentRepository.DeleteStudent(studentId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return isRemoved;
        }
    }
}