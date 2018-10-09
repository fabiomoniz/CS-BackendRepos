using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopCage.core.Domain.Services;
using WebShopCage.core.entity;

namespace WebShopCage.Infrastruture.Data.Repo
{
    public class ProductRepo : IProductRepo
    {
        private readonly DBContext _ctx;

        public ProductRepo(DBContext ctx)
        {
            _ctx = ctx;
        }

        public Products Create(Products products)
        {
            var newProduct = _ctx.Products.Add(products).Entity;
            _ctx.SaveChanges();
            return newProduct;
        }

        public Products Delete(int id)
        {
            var productfound = ReadById(id);
            if (productfound == null) return null;

            _ctx.Products.Remove(productfound);
            return productfound;
        }

        public IEnumerable<Products> ReadAll()
        {
            return _ctx.Products;
        }

        public Products ReadById(int id)
        {
            return _ctx.Products.
                Select(c => new Products()
                {
                    Id = c.Id,
                    ProductType = c.ProductType,
                    ProductPrice = c.ProductPrice,
                    ProductSize = c.ProductSize
                }).
                FirstOrDefault(c => c.Id == id);
        }

        public Products Update(Products productsUpdate)
        {
            var productFromDB = ReadById(productsUpdate.Id);
            if (productFromDB == null) return null;

            productFromDB.ProductType = productsUpdate.ProductType;
            productFromDB.ProductSize = productsUpdate.ProductSize;
            productFromDB.ProductPrice = productsUpdate.ProductPrice;
            productFromDB.ProductStock = productsUpdate.ProductStock;
            return productFromDB;
        }
    }
}
