using System;
using System.Collections.Generic;
using System.Text;
using WebShopCage.core.entity;

namespace WebShopCage.core.Aplications.Services
{
    public interface IProductService
    {
        Products NewProduct(string productType,
                            string productSize,
                            double productPrice,
                            int productStock);

        //Create //POST
        Products CreateProduct(Products prod);
        //Read //GET
        Products FindProductById(int id);
        List<Products> GetAllProducts();
        List<Products> GetAllByID(string name);
        //Update //PUT
        Products UpdateProduct(Products productsUpdate);

        //Delete //DELETE
        Products DeleteProduct(int id);
    }
}
