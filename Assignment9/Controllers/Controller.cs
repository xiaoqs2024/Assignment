using System;
using System.Collections.Generic;
using System.Linq;
using Assignment9.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;//导入安装的插件

namespace Assignment9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller:ControllerBase
    {
        private readonly OrderContext orderDb;
        public Controller(OrderContext oderContext)
        {
            this.orderDb = oderContext;
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orderDb.orders.FirstOrDefault(t => t.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }
        [HttpPost]
        public ActionResult<Order> PostTodoItem(Order order)
        {
            try
            {
                orderDb.orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                    : e.InnerException.Message;
                return BadRequest(error);
            }
            return order;
        }
        [HttpPut("{id}")]
        public ActionResult<Order> PutTodoItem(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                    : e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(int id)
        {
            try
            {
                var order = orderDb.orders.FirstOrDefault(t => t.Id == id);
                if (order != null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                   : e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
    }
}
