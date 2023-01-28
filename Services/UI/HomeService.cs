using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Services
{
    public class HomeService : IHomeService
    {
        private readonly StudentMenuService studentMenu;
        private readonly LibrariantMenuService librariantMenu;
        public HomeService()
    {
        this.studentMenu = new StudentMenuService();
        this.librariantMenu = new LibrariantMenuService();
    }
        public void LoadExistingMenus()
        {
            string menus = "1.Talabalar\n2.Kutubxonachilar\n3.Ijaralar\n4.Chiqish";
            Console.WriteLine("<====Menu====>");
            Console.WriteLine(menus);
            Console.Write("menyuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);
            Console.Clear();
            switch(option)
            {
                case 1:
                    this.studentMenu.LoadStudentMenu(); break;
                case 2:
                    this.librariantMenu.LoadLibrariantMenu(); break;
                case 3:;break;
                case 4:
                    Environment.Exit(0); break;
            }
        }
    }
}