using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_DexterStephens.Models;
using Mission6_DexterStephens.Models.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_DexterStephens.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieContext movieContext)
        {
            _logger = logger;
            _movieContext = movieContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(MovieModel movieModel)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            if (ModelState.IsValid)
            {
                try
                {
                    _movieContext.Add(movieModel);
                    _movieContext.SaveChanges();

                    ViewData["success"] = "Your movie has been submitted";
                    MovieModel newModel = new MovieModel();
                    return View(newModel);
                }
                catch
                {
                    return View(movieModel);
                }
            }
            else
            {
                return View(movieModel);
            }
            
        }

        public IActionResult MovieList()
        {
            var movies = _movieContext.Movies.Include(x => x.Category).ToList();
           return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(string title)
        {
            var movie = _movieContext.Movies.Single(x => x.Title == title);
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View("NewMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel movieModel)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            if (ModelState.IsValid)
            {
                try
                {
                    _movieContext.Update(movieModel);
                    _movieContext.SaveChanges();

                    return RedirectToAction("MovieList");
                }
                catch
                {
                    return View("NewMovie", movieModel);
                }
            }
            else
            {
                return View("NewMovie", movieModel);
            }
        }

        public IActionResult Delete(string title)
        {
            try
            {
                var movie = _movieContext.Movies.Single(x => x.Title == title);
                _movieContext.Movies.Remove(movie);
                _movieContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            catch
            {
                return RedirectToAction("MovieList");
            }
        }
    }
}
