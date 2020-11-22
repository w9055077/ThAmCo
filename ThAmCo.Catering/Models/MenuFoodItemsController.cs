﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Catering.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuFoodItemsController : ControllerBase
    {
        private readonly CateringContext _context;

        public MenuFoodItemsController(CateringContext context)
        {
            _context = context;
        }

        // GET: api/MenuFoodItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuFoodItem>>> GetMenuFoodItems()
        {
            return await _context.MenuFoodItems.ToListAsync();
        }

        // GET: api/MenuFoodItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuFoodItem>> GetMenuFoodItem(int id)
        {
            var menuFoodItem = await _context.MenuFoodItems.FindAsync(id);

            if (menuFoodItem == null)
            {
                return NotFound();
            }

            return menuFoodItem;
        }

        // PUT: api/MenuFoodItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuFoodItem(int id, MenuFoodItem menuFoodItem)
        {
            if (id != menuFoodItem.MenuFoodItemId)
            {
                return BadRequest();
            }

            _context.Entry(menuFoodItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuFoodItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MenuFoodItems
        [HttpPost]
        public async Task<ActionResult<MenuFoodItem>> PostMenuFoodItem(MenuFoodItem menuFoodItem)
        {
            _context.MenuFoodItems.Add(menuFoodItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuFoodItem", new { id = menuFoodItem.MenuFoodItemId }, menuFoodItem);
        }

        // DELETE: api/MenuFoodItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MenuFoodItem>> DeleteMenuFoodItem(int id)
        {
            var menuFoodItem = await _context.MenuFoodItems.FindAsync(id);
            if (menuFoodItem == null)
            {
                return NotFound();
            }

            _context.MenuFoodItems.Remove(menuFoodItem);
            await _context.SaveChangesAsync();

            return menuFoodItem;
        }

        private bool MenuFoodItemExists(int id)
        {
            return _context.MenuFoodItems.Any(e => e.MenuFoodItemId == id);
        }
    }
}
