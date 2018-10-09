using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopCage.core.Domain.Services;
using WebShopCage.core.entity;

namespace WebShopCage.Infrastruture.Data.Repo
{
    public class OrderRepo : IOrderRepo
    {
        private readonly DBContext _ctx;

        public OrderRepo(DBContext ctx)
        {
            _ctx = ctx;
        }

        public Orders Create(Orders order)
        {
            var newOrder = _ctx.Order.Add(order).Entity;
            _ctx.SaveChanges();
            return newOrder;
            
        }

        public Orders Delete(int id)
        {
            var orderfound = ReadById(id);
            if (orderfound == null) return null;

            _ctx.Order.Remove(orderfound);
            return orderfound;
        }

        public IEnumerable<Orders> ReadAll()
        {
            return _ctx.Order;
        }

        public Orders ReadById(int id)
        {
            return _ctx.Order.
                Select(c => new Orders()
                {
                    Id = c.Id,
                    OrderDate = c.OrderDate,
                    DeliveryDate = c.DeliveryDate,
                    Products = c.Products
                }).
                FirstOrDefault(c => c.Id == id);
        }
    }
}
