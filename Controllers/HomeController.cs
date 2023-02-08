using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(MovieModel movieModel)
        {
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
    }
}
