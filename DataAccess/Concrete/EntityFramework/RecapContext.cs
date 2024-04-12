using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RecapContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OtherCustomer>().HasNoKey();

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.OtherCustomers)
            //    .WithOne()
            //    .IsRequired(); // Assuming a user must have at least one customer, adjust as needed

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=true;");
            //base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> OtherCustomers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
