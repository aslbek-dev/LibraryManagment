using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public interface IRentService
    {
        List<Rent> RetrieveRents();
        Rent RetrieveRent(int rentId);
        Rent AddRent(Rent rent);
        Rent ModifyRent(int rentId, Rent rent);
        bool DeleteRent(int rentId);
        
    }
}