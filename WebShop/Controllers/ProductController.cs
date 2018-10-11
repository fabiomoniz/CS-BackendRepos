using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShopCage.core.Aplications.Services;
using WebShopCage.core.entity;

namespace WebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        
        // GET api/customers -- READ All
        [HttpGet]
        public ActionResult<IEnumerable<Products>> Get()
        {
            return _productService.GetAllProducts();
        }

        // GET api/customers/5 -- READ By Id
        [HttpGet("{id}")]
        public ActionResult<Products> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");
            
            //return _customerService.FindProductById(id);
            return _productService.FindProductById(id);
        }
        
        // POST api/customers -- CREATE
        [HttpPost]
        public ActionResult<Products> Post([FromBody] Products products)
        {
            if (string.IsNullOrEmpty(products.ProductType))
            {
                return BadRequest("Product name is required for creating a product");
            }

            if (string.IsNullOrEmpty(products.ProductSize))
            {
                return BadRequest("Product Size is required for creating a product");
            }
            //return StatusCode(503, "Horrible Error CALL Tech Support");
            return _productService.CreateProduct(products);
        }
        
        // PUT api/customers/5 -- Update
        [HttpPut("{id}")]
        public ActionResult<Products> Put(int id, [FromBody] Products products)
        {
            if (id < 1 || id != products.Id)
            {
                return BadRequest("Parameter Id and product ID must be the same");
            }

            return Ok(_productService.UpdateProduct(products));
        }
        
        // DELETE api/customers/5
        [HttpDelete("{id}")]
        public ActionResult<Products> Delete(int id)
        {
            var customer = _productService.DeleteProduct(id);
            if (customer == null)
            {
                return StatusCode(404, "Did not find product with ID " + id);
            }

            return Ok($"Product with Id: {id} is Deleted");
        }
    }
}