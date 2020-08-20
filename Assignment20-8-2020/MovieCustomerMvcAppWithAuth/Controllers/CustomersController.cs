using MovieCustomerMvcAppWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCustomerMvcAppWithAuth.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var singleCustomer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (singleCustomer == null)
                return HttpNotFound();
            return View(singleCustomer);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}