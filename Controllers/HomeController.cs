using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crudelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace Crudelicious.Controllers
{
    public class HomeController : Controller
    {
        MyContext db;

        public HomeController(MyContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dishes> AllDishes = db.Dishes.ToList();
            return View(AllDishes);
        }

        // Show add new dish page, with empty form
        [HttpGet("new")]
        public IActionResult addDish()
        {
            return View();
        }


        [HttpPost("dish/new")]
        public IActionResult AddDish(Dishes newDish)
        {
            // if model is valid, save to db, redirect to index
            if (ModelState.IsValid)
            {
                db.Add(newDish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // if model is NOT valid, return to new dish form page
                return View("addDish", newDish);
            }

        }

        [HttpGet("")]
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
