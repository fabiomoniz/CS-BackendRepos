using System;
using System.Collections.Generic;
using System.Text;
using WebShopCage.core.entity;

namespace WebShopCage.core.Domain.Services
{
    public interface IOrderRepo
    {
        //Create Data
        //No Id when enter, but Id when exits
        Orders Create(Orders order);
        //Read Data
        Orders ReadById(int id);
        IEnumerable<Orders> ReadAll();
        //Delete Data
        Orders Delete(int id);
    }
}
