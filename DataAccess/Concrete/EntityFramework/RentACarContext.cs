using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-1JKFIF2\bugra;Database=RentACar;Trusted_Connection=True");
            //optionsBuilder.UseSqlServer(@"Server=.\\SQLEXPRESS;Database=RentACar;Trusted_Connection=True");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1JKFIF2\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=True;");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
