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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Customers.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            if (userId == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                return View(_context.Employees);
            }
            //return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Customers
                .FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

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
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var employeeInDb = _context.Employees.Where(e => e.Id == id).FirstOrDefault();

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
                var employeeInDb = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
                employeeInDb.ZipCode = employee.ZipCode;
                employeeInDb.CompletedPickup = employee.CompletedPickup;
                employeeInDb.PickUpWithChargeApplied = employee.PickUpWithChargeApplied;
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

            var employeeInDb = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(employeeInDb);
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var employee = await _context.Employees
            //    .FirstOrDefaultAsync(m => m.ZipCode == id);
            //if (employee == null)
            //{
            //    return NotFound();
            //}

            //return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {

                var employeeInDb = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
                _context.Remove(employeeInDb);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            //var employee = await _context.Employees.FindAsync(id);
            //_context.Employees.Remove(employee);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        //private bool EmployeeExists(int id)
        //{
        //    return _context.Employees.Any(e => e.ZipCode == id);
        //}

        //public ActionResult TrashPickUpList()
        //{
            
        //}

        //public ActionResult FilterPickUps()
        //{

        //}

        //public ActionResult ConfirmPickUpComplete()
        //{

        //}

        //public ActionResult ConfirmPaymentApplied()
        //{

        //}
    }
}
