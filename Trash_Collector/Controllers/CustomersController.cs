using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using Trash_Collector.Data;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (userId == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                return View(_context.Customers);
            }




            //return View();
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var customer = _context.Customers.Where(c => c.IdentityUserId ==
            //userId).SingleOrDefault();
            //return View(customer);
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Customer customer)
        {
            

            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var customerInDb = _context.Customers.Where(c => c.Id == id).FirstOrDefault();

            return View(customerInDb);

            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var customer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            //if (userId == null)
            //{
            //    return NotFound();
            //}

            ////var customer = await _context.Customers.FindAsync(userId);

            //if (customer == null)
            //{
            //    return NotFound();
            //}
            //return View(customer);
        }



        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                var customerInDb = _context.Customers.Where(c => c.Id == id).FirstOrDefault();
                customerInDb.Name = customer.Name;
                customerInDb.PickUpDay = customer.PickUpDay;
                customerInDb.ExtraPickUp = customer.ExtraPickUp;
                customerInDb.SuspendPickUpDay = customer.SuspendPickUpDay;
                customerInDb.ContinuePickUpDay = customer.ContinuePickUpDay;
                customerInDb.ZipCode = customer.ZipCode;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(_context.Customers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {


            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }




    }
}
