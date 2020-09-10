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

namespace MovieCustomerMVCwithAuthen.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;
        // GET: Movie

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            //var movies =_context.Movies.Include(a=>a.Genre).ToList();
            if (User.IsInRole(RoleName.CanManageMovies))
            {
                IEnumerable<Movie> movies;
                HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Movie").Result;
                movies = response.Content.ReadAsAsync<IEnumerable<Movie>>().Result;
                return View(movies);
            }
            else
            {
                var movie = _context.Movies.Include(c => c.Genre).ToList();
                return View("Index", movie);
            }

        }
        public ActionResult Details(int id)
        {
            var singleMovie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            if (singleMovie == null)
            {
                return HttpNotFound();
            }
            return View(singleMovie);
        }

        [HttpGet]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            HttpResponseMessage mresponse = GlobalVariables.webApiClient.GetAsync("Genre").Result;
            var genres = mresponse.Content.ReadAsAsync<IEnumerable<Genre>>().Result;
            var viewModel = new NewMovieViewModel
            {
                Genres = genres
            };
            return View(viewModel);

            //var genre = _context.Genres.ToList();
            //var viewModel = new NewMovieViewModel
            //{
            //    Genres = genre
            //};
            //return View(viewModel);
        }


        //[HttpPost]
        //public ActionResult Create(Movie movie)
        //{
        //    _context.Movies.Add(movie);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Movie");
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
           
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new NewMovieViewModel(movie)
            //    {
            //        // Movie = movie,
            //        Genres = _context.Genres.ToList()
            //    };
            //    return View("New", viewModel);
            //}

            //if (movie.Id == 0)
            //    _context.Movies.Add(movie);
            //else
            //{
            //    var MovieInDb = _context.Movies.Single(c => c.Id == movie.Id);
            //    MovieInDb.MovieName = movie.MovieName;
            //    MovieInDb.Genre = movie.Genre;

            //}
            //_context.SaveChanges();
            //return RedirectToAction("Index", "Movie");//Back to Movie  controller page

           
            HttpResponseMessage mresponse = GlobalVariables.webApiClient.GetAsync("Genre").Result;
            var genres = mresponse.Content.ReadAsAsync<IEnumerable<Genre>>().Result;
            HttpResponseMessage cresponse = GlobalVariables.webApiClient.GetAsync("Movie").Result;
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel
                {
                    Genres = genres
                };

                return View("New", viewModel);
            }
            if (movie.Id == 0)
                cresponse = GlobalVariables.webApiClient.PostAsJsonAsync("Movie", movie).Result;
            else
            {
                cresponse = GlobalVariables.webApiClient.PutAsJsonAsync($"Movie/{movie.Id}", movie).Result;
            }
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            //var updateMov = _context.Movies.SingleOrDefault(c => c.Id == id);
            //if (updateMov == null)
            //{
            // return HttpNotFound();
            //}
            Movie movie;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Movie?id=" + id.ToString()).Result;
            movie = response.Content.ReadAsAsync<Movie>().Result;

            HttpResponseMessage response1 = GlobalVariables.webApiClient.GetAsync("Genre").Result;
            var vm = new NewMovieViewModel(movie)
            {
                Genres = response1.Content.ReadAsAsync<IEnumerable<Genre>>().Result
            };
            return View("New", vm);


        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movieTbl = _context.Movies.Find(id);
            _context.Movies.Remove(movieTbl);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}