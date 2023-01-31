using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Models;

namespace LibraryManagment.Data
{
    public class RentRepository : IRentRepository
    {
        private Dictionary<int, Rent> rents;
       // public RentRepository()
        {
            this.rents = new Dictionary<int, Rent>();
        }
        public List<Rent> SelectAllRents() =>
            this.rents.Values.ToList();
        public Rent SelectRentById(int rentId)
        {
            if(!rents.ContainsKey(rentId))
                throw new KeyNotFoundException("this rent not found");
            return rents[rentId];
        }
        public Rent InsertRent(Rent rent)
        {
            if(this.rents.ContainsKey(rent.RentId))
                throw new ArgumentException("rent with this key already exits");
            this.rents.Add(rent.RentId, rent);
            return rent;
        }
        public Rent UpdateRent(int rentId, Rent rent)
        {
            if(!this.rents.ContainsKey(rentId))
                throw new KeyNotFoundException("rent not found");
            var changingRent = this.rents[rentId];
            changingRent.IsReturned = rent.IsReturned;
            return changingRent;
        }
        public bool DeleteRent(int rentId)
        {
            if(!rents.ContainsKey(rentId))
                throw new KeyNotFoundException("rent not found");
            return rents.Remove(rentId);
        }
    }
}