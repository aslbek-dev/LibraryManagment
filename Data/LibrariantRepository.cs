using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Data
{
    public class LibrariantRepository : ILibrariantRepository
    {
        private Dictionary<int, User> librariants;
        public LibrariantRepository()
        {
            this.librariants = new Dictionary<int, User>();
        }
        public bool DeleteLibrariant(int librariantId)
        {
            if(!librariants.ContainsKey(librariantId))   
                throw new KeyNotFoundException("Librariant not found");
            return librariants.Remove(librariantId);
             
        }

        public User? InsertLibrariant(User librariant)
        {
            if(librariants.ContainsKey(librariant.UserId))
                throw new ArgumentException("Librariant with this key already exits");
            librariants.Add(librariant.UserId, librariant);
            return librariant;
        }

        public List<User> SelectAllLibrariants()=>
            librariants.Values.ToList();

        public User SelectLibrariantByID(int librariantId)
        {
            if(!librariants.ContainsKey(librariantId))   
                throw new KeyNotFoundException("Librariant not found");
            
            return librariants[librariantId];
        }

        public User UpdateLibrariant(int librariantId, User librariant)
        {
            if(!librariants.ContainsKey(librariantId))   
                throw new KeyNotFoundException("Librariant not found");
            var existingLibrariant = librariants[librariantId];
            if(string.IsNullOrEmpty(librariant.Name))
                existingLibrariant.Name = librariant.Name;
            return existingLibrariant;
        }
    }
}