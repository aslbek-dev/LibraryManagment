

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public class LibrariantMenuService : ILibrariantMenuService
    {
        private ILibrariantService librariantService;
         private void Back()
        {
            Console.WriteLine("\n\norqaga qaytish - 0...");
            Console.WriteLine("\nChiqish -1...");
            int.TryParse(Console.ReadLine(), out int option);
            switch(option)
            {
                case 0:
                    LoadLibrariantMenu(); break;
                case 1:
                    Environment.Exit(0); break;
            }

        }
        public LibrariantMenuService()
        {
            this.librariantService = new LibrariantService();
            User temproryLibrariant = new User()
            {
                Name = "Sherbek",
                UserId = 100,
                UserType = UserType.Librariant,
                Birthday = DateTime.Now,
                Gender = Gender.Male
            };
            this.librariantService.AddLibrariant(temproryLibrariant);
        }
        private void DisplayLibrariant()
        {
            Console.Write("search...");
            string name = Console.ReadLine();
            var filteredLibrariant = this.librariantService.RetrieveLibrariants(name);
            for(int i = 0; i < filteredLibrariant.Count; i++)
            {
                Console.WriteLine($"{i+1}.{filteredLibrariant[i]}");
            }
            Back();
        }
        private void SearchlibrariantById()
        {
            Console.Write("ID...");
            int.TryParse(Console.ReadLine(), out int librariantId);
            var findedLibrariant = 
                this.librariantService.RetrieveLibrariant(librariantId);
            Console.WriteLine(findedLibrariant);
            Back();
        }
        private void PushLibrariant()
        {
            string inputPattern = "1.Name 2.Birthday"+
                                   " 3.Gender(Male or Female)"+
                                   " 4.UserId";
            Console.WriteLine(inputPattern);

            List<String> infoLibrariant  = Console.ReadLine().Split(" ").ToList();
            var librariant = new User();

            librariant.Name = infoLibrariant[0];

            librariant.Birthday = DateTime.Parse(infoLibrariant[1]);

            librariant.Gender = Enum.Parse<Gender>(infoLibrariant[2]);
            int.TryParse(infoLibrariant[3],out int k);

            librariant.UserId = k;

            librariant.UserType = UserType.Librariant;

            this.librariantService.AddLibrariant(librariant);

            Console.WriteLine(librariant);
            Back();
        }
        private void UpdateLibrariant()
        {
            Console.Write("Id: ");
            int librariantId = int.Parse(Console.ReadLine());

            User oldLibrariant = this.librariantService.RetrieveLibrariant(librariantId);
            Console.WriteLine(oldLibrariant);

            User librariant = new User();
            Console.Write("Ism: ");
            librariant.Name = Console.ReadLine();

            Console.Write("Tugilgan kun: ");
            string birthday = Console.ReadLine();

            if(string.IsNullOrEmpty(birthday))

                librariant.Birthday = librariant.Birthday;
            else
                librariant.Birthday = DateTime.Parse(birthday);
            
            Console.Write("Gender(Male or Female): ");
            string gender = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(gender))
                librariant.Gender = oldLibrariant.Gender;
            else
                librariant.Gender = Enum.Parse<Gender>(gender);

            Console.Write("ID: ");
            string userId = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(userId))
                librariant.UserId = oldLibrariant.UserId;
            else
                librariant.UserId = int.Parse(userId);
    
            Console.WriteLine(librariant);
            this.librariantService.ModifyLibrariant(librariantId, librariant);

            Console.WriteLine(oldLibrariant);
            Back();
        }
        private void DeleteLibrariant()
        {
            Console.Write("ID...");
            int.TryParse(Console.ReadLine(), out int librariantId);
            this.librariantService.RemoveLibrariant(librariantId);
            Back();
        }
        public void LoadLibrariantMenu()
        {
            Console.Clear();
            var homeService = new HomeService();
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
            Console.Clear();
            switch(option)
            {
                case 1:
                    DisplayLibrariant(); break;
                case 2:
                    SearchlibrariantById(); break;
                case 3:
                    PushLibrariant(); break;
                case 4:
                    UpdateLibrariant(); break;
                case 5:
                    DeleteLibrariant(); break;
                case 6:
                    homeService.LoadExistingMenus(); break;
            }
        }
    }
}