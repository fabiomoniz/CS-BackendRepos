using System;
using System.Collections.Generic;
using System.Text;
using WebShopCage.core.entity;

namespace WebShopCage.core.Domain.Services
{
    public interface IProductRepo
    {
        //Create Data
        //No Id when enter, but Id when exits
        Products Create(Products products);
        //Read Data
        Products ReadById(int id);
        IEnumerable<Products> ReadAll();
        //Update Data
        Products Update(Products productsUpdate);
        //Delete Data
        Products Delete(int id);
    }
}
