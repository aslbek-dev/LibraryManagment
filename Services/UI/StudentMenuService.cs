using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public class StudentMenuService : IStudentMenuService
    {
        private readonly IStudentService studentService;
        public StudentMenuService()
        {
            this.studentService = new StudentService();
        }
        private void DisplayStudent()
        {
            var temproryStudent = new User()
            {
                Name = "Amir",
                UserId = 1,
                UserType = UserType.Student,
                Birthday = DateTime.Now,
                Gender = Gender.Male
            };
            this.studentService.AddStudent(temproryStudent);
            
            var students = 
                this.studentService.RetrieveStudents();
            for(int i = 0; i < students.Count; i++)
                Console.WriteLine($"{i + 1}. {students[i]}");
        }
        public void LoadStudentMenu()
        {
            var homeService = new HomeService();
            string menu = "1.Ro'yxat\n"+
                          "2.Qidirish\n"+
                          "3.Qo'shish\n"+
                          "4.Yangilash\n"+
                          "5.O'chirish\n"+
                          "6.Orqaga\n";
            Console.WriteLine("<====Talabalar Menyu====>");
            Console.WriteLine(menu);
            Console.Write("menyuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);
            Console.Clear();
            switch(option)
            {
                case 1:
                    DisplayStudent(); break;
                case 6:
                    homeService.LoadExistingMenus(); break;
            }
        }
    }
}