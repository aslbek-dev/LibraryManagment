using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Data
{
    public class StudentRepository : IStudentRepository
    {
        public User DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public User InsertStudent(User student)
        {
            throw new NotImplementedException();
        }

        public List<User> SelectAllStudents()
        {
            throw new NotImplementedException();
        }

        public User SelectStudentById(int studentId)
        {
            throw new NotImplementedException();
        }

        public User UpdateStudent(int studentId, User student)
        {
            throw new NotImplementedException();
        }
    }
}