using MovieCustomerMVCwithAuthen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieCustomerMVCwithAuthen.Controllers.api
{
    public class MembershipController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public MembershipController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/customers
        public IHttpActionResult GetMembership()   //chng in 7/9/20--for include add data.entity namespace
        {
            IEnumerable<MembershipType> membership;
            membership = _context.MembershipTypes.ToList();
            //return _context.Customers.ToList();
            if (membership == null)
                return NotFound();
            return Ok(membership);
        }
    }
}