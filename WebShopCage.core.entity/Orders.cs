using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopCage.core.entity
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<Products> Products { get; set; }

    }
}
