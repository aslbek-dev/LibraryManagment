using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Services
{
    public class StudentMenu : IStudentMenu
    {
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
                case 6:
                    homeService.LoadExistingMenus(); break;
            }
           

        }
    }
}