using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager manager = new (new EfCarRepository());

        manager.GetAll().ForEach(i =>
        {
            Console.WriteLine($"Marka : {i.Description} Fiyatı : {i.DailyPrice}");
        });

        Console.ReadLine();
    }
}