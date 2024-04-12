using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public Car()
        {

        }
        public Car(int brandId, int colorId, int modelYear, decimal dailyPrice, string description)
        {
            BrandId = brandId;
            ColorId = colorId;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
        }

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
