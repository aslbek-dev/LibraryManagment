using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Data;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public class LibrariantService : ILibrariantService
    {   
        private readonly LibrariantRepository librariantRepository;
        public LibrariantService(ILibrariantRepository librariantRepository)
        {
            this.librariantRepository = new LibrariantRepository();
        }
        public IEnumerable<User> RetrieveLibrariants(string name)
        {
            var librariants =
                this.librariantRepository.SelectAllLibrariants();
            if(!string.IsNullOrEmpty(name))  
            {
                var filteredLibrariants = new List<User>();
                foreach(var librariant in librariants)
                    if(librariant.Name.Contains(name))
                        filteredLibrariants.Add(librariant);

                return filteredLibrariants;
            }
            return librariants;  

        }
        public User? RetrieveLibrariant(int librariantId)
        {
            User? librariant = null;
            try
            {
                librariant = 
                    this.librariantRepository.SelectLibrariantByID(librariantId);

                return librariant;
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return librariant;
        }
        public User? AddRetrieveLibrariant(User librariant)
        {
            User? insertedLibrariant = null;
            try
            {
                insertedLibrariant = 
                    this.librariantRepository.InsertLibrariant(insertedLibrariant);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return insertedLibrariant;
        }

        public User? ModifyLibrariant(int librariantId, User librariant)
        {
            User? modifiedLibrariant = null;
            try
            {
                modifiedLibrariant = 
                    this.librariantRepository.UpdateLibrariant(librariantId, librariant);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return modifiedLibrariant;
        }

        public bool RemoveLibrariant(int librariantId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved = 
                    this.librariantRepository.DeleteLibrariant(librariantId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return isRemoved;
        }

    }
}