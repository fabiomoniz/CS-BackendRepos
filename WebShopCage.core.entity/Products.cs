using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopCage.core.entity
{
    public class Products
    {
        public int Id { get; set; }

        public string ProductType { get; set; }

        public double ProductPrice { get; set; }

        public string ProductSize { get; set; }

        public int ProductStock { get; set; }
    }
}
