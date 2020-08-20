using MovieCustomerMvcAppWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCustomerMvcAppWithAuth.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var singleMovie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (singleMovie == null)
                return HttpNotFound();
            return View(singleMovie);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}