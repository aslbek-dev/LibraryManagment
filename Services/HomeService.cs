using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Services
{
    public class HomeService : IHomeService
    {
        private readonly IStudentService studentService;
        private readonly ILibrariantService librariantService;
        public HomeService()
        {
            this.studentService = new StudentService();
            this.librariantService = new LibrariantService();
        }
        public void LoadExistingMenus()
        {
            string menus = "1.Talabalar\n2.Kutubxonachilar";
            Console.WriteLine(menus);
            int option;
        }
        private void LoadLibrariantMenu()
        {

        }
        private void LoadStudentMenu()
        {

        }
    }
}