using System.Data.Entity;

namespace OrderApp
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public OrderDbContext() : base("server=localhost;user id=root;password=fj29chsn2i;database=orderdb;")
        {
        }
    }
}
