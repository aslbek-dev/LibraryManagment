using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Services
{
    public class LibrariantMenu : ILibrariantMenu
    {
        private readonly IHomeService homeService;
        public LibrariantMenu()
        {
            this.homeService = new HomeService();
        }
        public void LoadLibrariantMenu()
        {
            string menu = "1.Ro'yxat\n"+
                          "2.Qidirish\n"+
                          "3.Qo'shish\n"+
                          "4.Yangilash\n"+
                          "5.O'chirish\n"+
                          "6.Orqaga\n";
            Console.WriteLine("<====Kutubxonachilar Menyu====>");
            Console.WriteLine(menu);
            Console.Write("menyuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);
            switch(option)
            {
                case 6:
                    this.homeService.LoadExistingMenus(); break;
            }
        }
    }
}