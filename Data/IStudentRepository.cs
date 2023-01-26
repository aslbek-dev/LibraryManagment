using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Data
{
    public interface IStudentRepository
    {
       List<User> SelectAllStudents();
       User SelectStudentById(int studentId);
       User InsertStudent(User student);
       User UpdateStudent(int studentId, User student);
       bool DeleteStudent(int studentId);
    }
}