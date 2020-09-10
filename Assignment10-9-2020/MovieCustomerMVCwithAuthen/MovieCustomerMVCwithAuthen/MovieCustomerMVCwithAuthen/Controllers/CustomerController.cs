using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCustomerMVCwithAuthen.Models;
using System.Data.Entity;
using MovieCustomerMVCwithAuthen.ViewModel;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;

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
        // GET: Customers
       
        public ActionResult Index()
        { 
            IEnumerable<Customer> customers;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Customer").Result;
            customers = response.Content.ReadAsAsync<IEnumerable<Customer>>().Result;

            //var customers = _context.Customer.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            ////These part is without Api
            //var singleCustomer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
            //if (singleCustomer == null)
            //    return HttpNotFound();
            //return View(singleCustomer


            //with Api
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync($"Customer/{id}").Result;
            Customer singleCust;
            singleCust = response.Content.ReadAsAsync<Customer>().Result;
            return View(singleCust);
        }
        [HttpGet]
        public ActionResult New()  
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }
        //[HttpPost]
        //public ActionResult Create(Customer customer)  //submit the form,parameter is of model
        //                                               //must have parameter in Post method      //Its called Model Binding
        //{
        //    _context.Customers.Add(customer);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Customer");//Back to customer controller page
        //}

        //..................................................Save.........................chng-7/9/20
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                HttpResponseMessage response1 = GlobalVariables.webApiClient.GetAsync("Membership").Result;
                var viewModel = new NewCustomerViewModel(customer)
                {
                    MembershipTypes = response1.Content.ReadAsAsync<IEnumerable<MembershipType>>().Result
                };
                return View("New", viewModel);
            }
            //Web Api method//
            if (customer.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("Customer", customer).Result;
                return RedirectToAction("Index", "Customer");
            }
            else
            {

                HttpResponseMessage response = GlobalVariables.webApiClient.PutAsJsonAsync($"Customers/{customer.Id}", customer).Result;
                return RedirectToAction("Index", "Customer");
            }


            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new NewCustomerViewModel(customer)
            //    {

            //        MembershipTypes=_context.MembershipTypes.ToList()
            //    };
            //    return View("New",viewModel);
            //}
            //else
            //{
            //     HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("Customers",customer).Result;
            //     return RedirectToAction("Index", "Customers");



            //}
        }

        //        if (customer.Id == 0) _context.Customers.Add(customer);
        //        else
        //        {
        //            //var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
        //            //customerInDb.Name = customer.Name;
        //            //customerInDb.DOB = customer.DOB;
        //            //customerInDb.MembershipTypeId = customer.MembershipTypeId;
        //            //customerInDb.IsSubscribe = customer.IsSubscribe;
        //        }
        //         //changes done here for saving on 1/9/2020
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Customer");
        //}


        //...............................................................Edit..................................
        //public ActionResult Edit(int id)
        //{
        //    var updateCust = _context.Customer.SingleOrDefault(c => c.Id == id);
        //   if (updateCust == null)
        //   {
        //        return HttpNotFound();
        //    }
        //    var vm = new NewCustomerViewModel(updateCust)
        //    {

        //       MembershipTypes = _context.MembershipTypes.ToList()
        //   };
        //   return View("New",vm);
        //}

        //............................................Edit with Api.............................

        public ActionResult Edit(int id)
        {
            Customer customer;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Customer?id=" + id.ToString()).Result;
            customer = response.Content.ReadAsAsync<Customer>().Result;
            //var updateCust = _context.Customer.SingleOrDefault(c => c.Id == id);
            //  if (updateCust == null)
            //   {
            //       return HttpNotFound();
            //   }
            HttpResponseMessage response1 = GlobalVariables.webApiClient.GetAsync("Membership").Result;
            //HttpResponseMessage cust = GlobalVariables.webApiClient.GetAsync("Customers?id=" + id.ToString()).Result;
            var vm = new NewCustomerViewModel(customer)
            {

                MembershipTypes = response1.Content.ReadAsAsync<IEnumerable<MembershipType>>().Result

            };


            return View("New", vm);


        }


        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var customerTbl = _context.Customer.Find(id);
        //    _context.Customer.Remove(customerTbl);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Customer");
        //}

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}