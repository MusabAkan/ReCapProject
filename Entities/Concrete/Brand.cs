using Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        //public int Id { get; set; }
        public int BrandId { get; set; }
        public Color ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
