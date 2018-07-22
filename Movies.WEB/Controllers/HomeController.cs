using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.WEB.Models;
using Movies.WEB.Services;


namespace Movies.WEB.Controllers
{
    public class HomeController : Controller
    {
        private IMovieService _MovieService;

        public HomeController(IMovieService movieService)
        {
            _MovieService = movieService;
        }

        public IActionResult Index()
        {
            List<MovieViewModel> movies = _MovieService.GetMovies();
            return View(movies);
        }

        public IActionResult AddMovies()
        {
            using(var dbContext = new MoviesDBContext())
            {
                List<MovieViewModel> movies = _MovieService.GetMovies();

                foreach(var movie in movies)
                {
                    dbContext.Movies.Add(movie);
                    dbContext.SaveChanges();
                }

            }
            return RedirectToAction("Index");
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            
        }
    }
}
