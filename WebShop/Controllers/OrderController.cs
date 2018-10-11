using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShopCage.core.Aplications.Services;
using WebShopCage.core.entity;

namespace WebShop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        
        // GET api/orders -- READ All
        [HttpGet]
        public ActionResult<IEnumerable<Orders>> Get()
        {
            return Ok(_orderService.GetAllOrders());
        }
        
        // GET api/orders/5 -- READ By Id
        [HttpGet("{id}")]
        public ActionResult<Orders> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater than 0");
            
            return Ok();
        }
        
        // POST api/orders -- CREATE
        [HttpPost]
        public ActionResult<Orders> Post([FromBody] Orders order)
        {
            try
            {
                return Ok(_orderService.CreateOrder(order));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
        
        // PUT api/orders/5 -- Update
        [HttpPut("{id}")]
        public ActionResult<Orders> Put(int id, [FromBody] Orders order)
        {
            if (id < 1 || id != order.Id)
            {
                return BadRequest("Parameter Id and order ID must be the same");
            }

            return Ok();
        }
        
        // DELETE api/orders/5
        [HttpDelete("{id}")]
        public ActionResult<Orders> Delete(int id)
        {
            return Ok($"Order with Id: {id} is Deleted");
        }
    }
}