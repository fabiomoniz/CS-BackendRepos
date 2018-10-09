using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShopCage.core.entity;

namespace WebShopCage.Infrastruture.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> opt)
            : base(opt) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().HasMany(o => o.Products);
        }


        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Order { get; set; }
    }
}
