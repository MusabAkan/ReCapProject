using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

public class Program
{
    private static void Main(string[] args)
    {
        CarManager manager = new(new EfCarRepository());

        //manager.GetAll().ForEach(i =>
        //{
        //    Console.WriteLine($"Marka : {i.Description} Fiyatı : {i.DailyPrice}");
        //});
        var result = manager.GetCarDetails();
        if (result.Success)
        {
            result.Data.ForEach(car =>
            {
                Console.WriteLine("Araba Adı : " + car.CarName + ", Firma Adı : " + car.BrandName + ", Renk : " + car.ColorName + ", Fiyat : " + car.DailyPrice);
            });
        }
        Console.ReadLine();
    }
}