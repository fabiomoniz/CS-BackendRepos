using CustomerApp.Core.Entity;
using Microsoft.EntityFrameworkCore;


namespace CustomerApp.Infrastructure.Static.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> opt)
            : base(opt) {}
        


 
        public DbSet<Products> Products { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}