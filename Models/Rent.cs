namespace LibraryManagment.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public int UserId { get; set; }
        public int? BookId { get; set; }
        public DateTime RentAt { get; set; }
        public DateTime ReturnAt { get; set; }
        public bool IsReturned { get; set; }
        
    }
}