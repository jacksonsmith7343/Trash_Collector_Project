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
            Customer customer = new Customer();
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                 customer = _context.Customers.Where(e => e.IdentityUserId == userId).Single();
            }
            catch(Exception)
            {

                return RedirectToAction("Create");
            }
                
            return View(customer);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(e => e.IdentityUserId == userId).SingleOrDefault();
           
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            Customer customer = new Customer();
            
            List<DayOfWeek> daysOfweek = new List<DayOfWeek>();
            daysOfweek.Add(DayOfWeek.Monday);
            daysOfweek.Add(DayOfWeek.Tuesday);
            daysOfweek.Add(DayOfWeek.Wednesday);
            daysOfweek.Add(DayOfWeek.Thursday);
            daysOfweek.Add(DayOfWeek.Friday);
           

            ViewData["weekdays"] = new SelectList(daysOfweek, customer.PickUpDay);


            return View(customer);
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
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;

                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(e => e.IdentityUserId == userId).SingleOrDefault();


            List<DayOfWeek> daysOfweek = new List<DayOfWeek>();
            daysOfweek.Add(DayOfWeek.Monday);
            daysOfweek.Add(DayOfWeek.Tuesday);
            daysOfweek.Add(DayOfWeek.Wednesday);
            daysOfweek.Add(DayOfWeek.Thursday);
            daysOfweek.Add(DayOfWeek.Friday);


            ViewData["weekdays"] = new SelectList(daysOfweek, customer.PickUpDay);
            
            return View(customer);
        }



        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customerInDb = _context.Customers.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            try
            {
                customerInDb.Name = customer.Name;
                customerInDb.PickUpDay = customer.PickUpDay;
                customerInDb.ExtraPickUp = customer.ExtraPickUp;
                customerInDb.ZipCode = customer.ZipCode;
                customerInDb.Address = customer.Address;
                customerInDb.ServiceSuspendedStart = customer.ServiceSuspendedStart;
                customerInDb.ServiceSuspendEnd = customer.ServiceSuspendEnd;


                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            var customerInDb = _context.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
            return View(customerInDb);

        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                
                var customerInDb = _context.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
                _context.Remove(customerInDb);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
