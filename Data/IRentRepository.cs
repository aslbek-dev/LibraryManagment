using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;
namespace LibraryManagment.Data
{
    public interface IRentRepository
    {
        List<Rent> SelectAllRents();
        Rent SelectRentById(int rentId);
        Rent InsertRent(Rent rent);
        Rent UpdateRent(int rentId, Rent rent);
        bool DeleteRent(int rentId);
    }
}