using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer()
        {

        }
        public Customer(int userId, string companyName)
        {
            UserId = userId;
            CompanyName = companyName;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
