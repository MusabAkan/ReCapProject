using Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Context
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            var context = scope.ServiceProvider.GetService<RecapContext>();

            context.Database.Migrate();

            if (context.Users.Count() == default)
            {
                //context.AddRange(
                //    new User("Musab", "Akan", "musab.akan@hotmail.com", "1234"),
                //    new User("Merve", "Salim", "merve5264@gmail.com", "merveince"),
                //    new User("Salih Can", "Taşkıran", "salihreiss07@gmail.com", "salihsalihsalih")
                //    );

                //Bıraya geliştir ha
                context.SaveChanges();
            }
            if (context.Customers.Count() == default)
            {
                context.AddRange(
                        new Customer(1, "Borusan"),
                        new Customer(2, "Hurriyet"),
                        new Customer(3,"Otosan")
                    );
                context.SaveChanges();
            }

            if (context.Brands.Count() == default)
            {
                context.AddRange(
                        new Brand("Ferrari"),
                        new Brand("BMW"),
                        new Brand("FIAT"),
                        new Brand("Ford")
                    );
            }

            if (context.Cars.Count() == default)
            {
                context.AddRange(
                   new Car(1, 1, 1992, 300000, "Hızlı bir araba "),
                   new Car(2, 1, 1990, 400000, "renkli bir araba "),
                   new Car(3, 2, 2005, 550000, "süper bir araba "),
                   new Car(4, 2, 2010, 250000, "ticari bir araba ")
                   );
            }

            if (context.Colors.Count() == default)
            {
                context.AddRange(
                    new Color("Kırmızı"),
                    new Color("Siyah"),
                    new Color("Beyaz"),
                    new Color("Mavi"),
                    new Color("Yeşil"),
                    new Color("Sarı"),
                    new Color("Turuncu"),
                    new Color("Mor"),
                    new Color("Pembe"),
                    new Color("Gri")
                    );

                context.SaveChanges();
            }

            if (context.Rentals.Count() == default)
            {
                context.AddRange(
                    new Rental(1, 1, new DateTime(2024, 01, 12), null),
                    new Rental(2, 2, new DateTime(2024, 06, 27), null),
                    new Rental(3, 3, new DateTime(2024, 11, 17), new DateTime(2024, 11, 25))

                    );
                context.SaveChanges();
            }

        }
    }
}

