using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopCage.core.Domain.Services;
using WebShopCage.core.entity;

namespace WebShopCage.core.Aplications.Services.Services
{
    public class ProductService : IProductService
    {
        readonly IProductRepo _productRepo;
        readonly IOrderRepo _orderRepo;

        public ProductService(IProductRepo productRepository,
            IOrderRepo orderRepository)
        {
            _productRepo = productRepository;
            _orderRepo = orderRepository;
        }


        public Products CreateProduct(Products prod)
        {
            //add exception here 


            return _productRepo.Create(prod);
        }

        public Products DeleteProduct(int id)
        {
            return _productRepo.Delete(id);
        }

        public Products FindProductById(int id)
        {
            return _productRepo.ReadById(id);
        }

        public List<Products> GetAllByID(string name)
        {
            var list = _productRepo.ReadAll();
            var queryContinued = list.Where(prod => prod.ProductType.Equals(name));
            queryContinued.OrderBy(customer => customer.ProductType);
            //Not executed anything yet
            return queryContinued.ToList();
        }

        public List<Products> GetAllProducts()
        {
            return _productRepo.ReadAll().ToList();
        }

        public Products NewProduct(string productType, string productSize, double productPrice , int productStock)
        {
            var prod = new Products()
            {
                ProductType = productType,
                ProductSize = productSize,
                ProductPrice = productPrice,
                ProductStock = productStock
            };

            return prod;
        }

        public Products UpdateProduct(Products productsUpdate)
        {
            var product = FindProductById(productsUpdate.Id);
            product.ProductType = productsUpdate.ProductType;
            product.ProductSize = productsUpdate.ProductSize;
            product.ProductPrice = productsUpdate.ProductPrice;
            product.ProductStock = productsUpdate.ProductStock;
            return product;
        }
    }
}
