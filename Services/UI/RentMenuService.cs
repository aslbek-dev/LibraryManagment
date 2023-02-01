using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Services
{
    public class RentMenuService : IRentMenuService
    {
        private readonly IRentService rentService;
        public RentMenuService()
        {
            this.rentService = new RentService();
        }
        public void LoadRentMenu()
        {
            Console.Clear();
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
                    DisplayRent(); break;
                case 2:
                    SearchRent(); break;
                case 3:
                    PushRent(); break;
                case 4:
                    ChangeRent(); break;
                case 5:
                    DeleteRent(); break;
                case 6:
                    homeService.LoadExistingMenus(); break;
            }
        }
        public void DisplayRent()
        {
            var rents = this.rentService.RetrieveRents();
            for(int i = 0; i < rents.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{rents[i]}");
            }
        }
        public void SearchRent()
        {
            Console.Write("Rent Id...");
            int.TryParse(Console.ReadLine(), out int rentId);
            var rent = this.rentService.RetrieveRent(rentId);
            Console.WriteLine(rent);
        }
        public void PushRent()
        {
            
        }
        public void ChangeRent()
        {

        }
        public void DeleteRent()
        {

        }

    }
}
