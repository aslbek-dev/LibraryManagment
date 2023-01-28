using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public interface IStudentService
    {
        IList<User> RetrieveStudents(string name = null);
        User RetrieveStudent(int studentId);
        User AddStudent(User student);
        User ModifyStudent(int studentId, User student);
        bool RemoveStudent(int studentId);

    }
}