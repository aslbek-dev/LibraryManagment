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
        public List<Rent> RetrieveRents()=>
        this.rentRepository.SelectAllRents();

        public Rent RetrieveRent(int rentId)
        {
            Rent rent = null;
            try
            {
                rent = this.rentRepository.SelectRentById(rentId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return rent;
        }
        public Rent AddRent(Rent rent)
        {
            Rent insertedRent = null;
            try
            {
                insertedRent = 
                    this.rentRepository.InsertRent(rent);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return insertedRent;
        }
        public Rent ModifyRent(int rentId, Rent rent)
        {
           Rent changingRent = null; 
            try
            {
                changingRent = 
                    this.rentRepository.UpdateRent(rentId, rent);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return changingRent;
        }

        public bool DeleteRent(int rentId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved = 
                    this.rentRepository.DeleteRent(rentId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return isRemoved;
        }
    }
}