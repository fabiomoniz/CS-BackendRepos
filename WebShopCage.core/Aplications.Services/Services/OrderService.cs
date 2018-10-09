using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebShopCage.core.Domain.Services;
using WebShopCage.core.entity;

namespace WebShopCage.core.Aplications.Services.Services
{
    public class OrderService : IOrderService
    {
        readonly IOrderRepo _orderRepo;
        readonly IProductRepo _productRepo;

        public OrderService(IOrderRepo orderRepo,
            IProductRepo productRepository)
        {
            _orderRepo = orderRepo;
            _productRepo = productRepository;
        }


        public Orders CreateOrder(Orders order)
        {
           /* if (order.Products == null || order.Products.Id <= 0)
                throw new InvalidDataException("To create Order you need a Customer");
            if (_productRepo.ReadById(order.Products.Id) == null)
                throw new InvalidDataException("Customer Not found");
            if (order.OrderDate == null)
                throw new InvalidDataException("Order needs a Order Date"); */

            return _orderRepo.Create(order);
        }

        public Orders DeleteOrder(int id)
        {
            return _orderRepo.Delete(id);
        }

        public Orders FindOrderById(int id)
        {
            return _orderRepo.ReadById(id);
        }

        public List<Orders> GetAllOrders()
        {
            return _orderRepo.ReadAll().ToList();
        }

        public Orders New()
        {
            return new Orders();
        }
    }
}
