using System;
using System.Collections.Generic;
using System.Text;
using WebShopCage.core.entity;

namespace WebShopCage.core.Aplications.Services
{
    public interface IOrderService
    {
        //New Order
        Orders New();

        //Create //POST
        Orders CreateOrder(Orders order);
        //Read //GET
        Orders FindOrderById(int id);
        List<Orders> GetAllOrders();

        //Delete //DELETE
        Orders DeleteOrder(int id);
    }
}
