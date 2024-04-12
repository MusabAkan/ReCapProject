using Core.Entities;
namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public Rental()
        {

        }
        public Rental(int carId, int customerId, DateTime rentDate, DateTime? returnDate)
        {
            CarId = carId;
            CustomerId = customerId;
            RentDate = rentDate;
            ReturnDate = returnDate;
        }

        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
