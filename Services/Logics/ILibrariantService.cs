using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public interface ILibrariantService
    {
        IList<User> RetrieveLibrariants(string name);
        User RetrieveLibrariant(int librariantId);
        User AddLibrariant(User librariant);
        User ModifyLibrariant(int librariantId, User librariant);
        bool RemoveLibrariant(int librariantId);
    }
}