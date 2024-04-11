using Core.Entities;

namespace Entities.Concrete
{
    public class OtherCustomer : IEntity
    {
        public int UserId { get; set; }
        public int CompanyName { get; set; }
    }
}
