using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trash_Collector.Data;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var employee = new Employee();
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee = _context.Employees.Where(e => e.IdentityUserId == userId).Single();
            }
            catch
            {
                return RedirectToAction("Create");
            }

            var today = DateTime.Today.Date;
            //TODO: customers with one time pickup
            var moreCustomers = _context.Customers.Where(c => c.ExtraPickUp.Date == today.Date).ToList();
            var customerWithSharedZip = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickUpDay == today.DayOfWeek && c.ServiceSuspendedStart < today && c.ServiceSuspendEnd < today).ToList();
            foreach (var item in moreCustomers)
            {
                customerWithSharedZip.Add(item);
            }
            return View(customerWithSharedZip);
        }

        
        public IActionResult ConfirmPickup(int CustomerId)
        {
            var customerFromDb = _context.Customers.Where(c => c.CustomerId == CustomerId).SingleOrDefault();
            customerFromDb.PaymentOwed += 15;
            _context.SaveChanges();
            return View(customerFromDb);
        }

        // GET: Employees/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var employee = await _context.Customers
        //        .FirstOrDefaultAsync(e => e.EmployeeId == id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employee);
        //}

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var employeeInDb = _context.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();

            return View(employeeInDb);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            try
            {
                var employeeInDb = _context.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
                employeeInDb.ZipCode = employee.ZipCode;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {

            var employeeInDb = _context.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            return View(employeeInDb);
            
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {

                var employeeInDb = _context.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
                _context.Remove(employeeInDb);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
           
        }




        public ActionResult FilterPickUps(DayOfWeek Today)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); //gains access to info about the user that is signed in 
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            var customersWithSpecificPickupDay = _context.Customers.Where(c => c.PickUpDay == Today).ToList();
            return View(customersWithSpecificPickupDay);
        }


       
    }
}
