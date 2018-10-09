using System;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Static.Data
{
    public class DBInitializer
    {
        public static void SeedDB(CustomerAppContext ctx)
        {
//            ctx.Database.EnsureCreated();
            var cust1 = ctx.Products.Add(new Customer()
            {
                Address = "BongiStreet",
                FirstName = "John",
                LastName = "Olesen"
            }).Entity;
                    
            var cust2 = ctx.Products.Add(new Customer()
            {
                Address = "BongiStreet 22",
                FirstName = "Bill",
                LastName = "Bøllesen"
            }).Entity;
                    
            var order1 = ctx.Orders.Add(new Order()
            {
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now,
                Customer = cust1
            }).Entity;
            ctx.Orders.Add(new Order()
            {
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now,
                Customer = cust1
            });
            ctx.Orders.Add(new Order()
            {
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now,
                Customer = cust2
            });
            var prod = ctx.Products.Add(new Product()
            {
                Name = "smølf"
            }).Entity;
            ctx.Products.Add(new Product()
            {
                Name = "Ko"
            });
            ctx.OrderLines.Add(new OrderLine()
            {
                Product = prod,
                Order = order1
            });
            ctx.SaveChanges();
        }
    }
}