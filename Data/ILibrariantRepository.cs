using LibraryManagment.Models;

namespace LibraryManagment.Data 
{
    public interface ILibrariantRepository
    {
        List<User> SelectAllLibrariants();
        User SelectLibrariantByID(int librariantId);
        User InsertLibrariant(User librariant);
        User UpdateLibrariant(int librariantId, User librariant);
        bool DeleteLibrariant(int librariantId);

    }
}