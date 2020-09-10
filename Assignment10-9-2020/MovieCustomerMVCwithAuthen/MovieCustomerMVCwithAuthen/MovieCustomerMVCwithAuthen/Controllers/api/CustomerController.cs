using MovieCustomerMVCwithAuthen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieCustomerMVCwithAuthen.Controllers.api
{
    public class CustomerController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/customers
        //public IEnumerable<Customer> GetCustomers()   //chng in 7/9/20--for include add data.entity namespace
        //{
        //    var customers = _context.Customers.Include(c => c.MembershipType).ToList();
        //    //return _context.Customers.ToList();

        //    return customers;
        //}

        public IHttpActionResult GetCustomers()
        {

            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            //return customers;
            //return _context.Customer.
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);

        }
        [HttpGet]
        public IHttpActionResult GetCustomer(int id)
        {
            if (id <= 0)

                return BadRequest("Not a vlid Customer id");
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            //throw new HttpResponseException(HttpStatusCode.NotFound);
            //return customer;
            {
                return NotFound();
            }
            return Ok(customer);
        }
        //POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }
        //PUT / api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Data");
            // throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerInDb = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            customerInDb.Name = customer.Name;
            customerInDb.DOB = customer.DOB;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            customerInDb.IsSubscribe = customer.IsSubscribe;
            _context.SaveChanges();
            return Ok();

        }
        //DELETE /api/customers/1
        public IHttpActionResult DeleteCustomer(int id)
        {
            if (id <= 0)

                return BadRequest("Not a valid Customer id");

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                // throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}