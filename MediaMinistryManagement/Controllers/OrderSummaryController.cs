﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediaMinistryManagement.Models.OrdersFolder.OrderSummary;

namespace MediaMinistryManagement.Controllers
{
    [Route("api/order_summary")]
    [ApiController]
    public class OrderSummaryController : ControllerBase
    {
        private readonly OrderSummaryContext _context;

        public OrderSummaryController(OrderSummaryContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderSummary>>> GetCustomers()
        {
            return await _context.Order_Summary.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderItem = await _context.Order_Summary.FindAsync(id);

            if (orderItem == null)
            {
                return NotFound();
            }

            return Ok(orderItem);
        }

        //// PUT: api/Orders/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutOrderItem([FromRoute] int id, [FromBody] OrderItem orderItem)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != orderItem.ORDER_NUMBER)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(orderItem).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OrderItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Orders
        //[HttpPost]
        //public async Task<IActionResult> PostOrderItem([FromBody] OrderItem orderItem)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Order_Summary.Add(orderItem);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetOrderItem", new { id = orderItem.ORDER_NUMBER }, orderItem);
        //}

        //// DELETE: api/Orders/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrderItem([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var orderItem = await _context.Order_Summary.FindAsync(id);
        //    if (orderItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Order_Summary.Remove(orderItem);
        //    await _context.SaveChangesAsync();

        //    return Ok(orderItem);
        //}

        private bool OrderItemExists(int id)
        {
            return _context.Order_Summary.Any(e => e.ORDER_NUMBER == id);
        }
    }
}