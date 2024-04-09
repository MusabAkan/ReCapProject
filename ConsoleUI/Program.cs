using Business.Concrete;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        BrandManager manager = new (new InMemoryBrandDal());

        manager.GetAll().ForEach(i =>
        {
            Console.WriteLine($"Marka : {i.Description} Fiyatı : {i.DailyPrice}");
        });

        Console.ReadLine();
    }
}