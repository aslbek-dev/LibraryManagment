using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;
using LibraryManagment.Data;

namespace LibraryManagment.Services.Logics
{
    public class RentService : IRentService
    {
        private readonly IRentRepository rentRepository;
        public RentService()
        {
            this.rentRepository = new RentRepository();
        }
        public Rent AddRent(Rent rent)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRent(int rentId)
        {
            throw new NotImplementedException();
        }

        public Rent ModifyRent(int rentId, Rent rent)
        {
            throw new NotImplementedException();
        }

        public Rent RetrieveRent(int rentId)
        {
            throw new NotImplementedException();
        }

        public List<Rent> RetrieveRents()
        {
            throw new NotImplementedException();
        }
    }
}