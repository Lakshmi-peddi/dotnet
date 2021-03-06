﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCustomerMVCwithAuthen.Models;
using System.Data.Entity;
using MovieCustomerMVCwithAuthen.ViewModel;
using System.Net;
using System.Net.Http;

namespace MovieCustomerMVCwithAuthen.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Customer
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Index()
        {
            IEnumerable<Customer> customers;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("CustomerApi").Result;
            customers = response.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
            return View(customers);
            //var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            //return View(customer);
        }
        public ActionResult Details(int id)
        {
            var singleCustomer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (singleCustomer == null)
            {
                return HttpNotFound();
            }
            return View(singleCustomer);

        }
        public ActionResult New()
        {
            var membership = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membership
            };
            return View(viewModel);
        }
        //[HttpPost]
        //public ActionResult Create(Customer customer)//Model binding
        //{
        //    _context.Customers.Add(customer);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Customer");
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel(customer)
                {
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("New",viewModel);
            }

            else
            {
                if (customer.Id == 0)
                {
                    _context.Customers.Add(customer);
                }
                else
                {
                    var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                    customerInDb.Name = customer.Name;
                    customerInDb.DOB = customer.DOB;
                    customerInDb.MembershipTypeId = customer.MembershipTypeId;
                    customerInDb.IsSubscribe = customer.IsSubscribe;
                }

                _context.SaveChanges();
                return RedirectToAction("Index", "Customer");
            }
        }

    
        public ActionResult Edit(int id)
        {
            var updateCust = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (updateCust == null)
            {
                return HttpNotFound();
            }
            var vm = new NewCustomerViewModel(updateCust)
            {
                
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("New",vm);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var customerTbl = _context.Customers.Find(id);
            _context.Customers.Remove(customerTbl);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}