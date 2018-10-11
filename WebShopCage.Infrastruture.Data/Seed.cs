using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopCage.core.entity;

namespace WebShopCage.Infrastruture.Data
{
    public class Seed
    {
        public static void DbSeed(DBContext ctx)
        {
            ctx.Database.EnsureCreated();
            if (!ctx.Products.Any())
            {
                ctx.Products.Add(new Products()
                {
                    ProductPrice = 200,
                    ProductSize = "XL",
                    ProductStock = 2,
                    ProductType = "Gloves"

                });
            }

            if (!ctx.Order.Any())
            {
                ctx.Order.Add(new Orders()
                {
                   // DateTime DeliveryDate = "11/11/18 23:59:59 ",
                    
                });
            }
        }
    }
}
