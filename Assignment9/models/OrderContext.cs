using Microsoft.EntityFrameworkCore;

namespace Assignment9
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
         : base(options)
        {
            this.Database.EnsureCreated(); 
        }

        public DbSet<Order> orders { get; set; } = null!;
    }
}
