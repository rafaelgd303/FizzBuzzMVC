using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private FizzBuzzClass fizzBuzzVariable = new FizzBuzzClass();
        
        public IActionResult Index()
        {
            var fizz = fizzBuzzVariable.FindFizzBuzz();
            ViewBag.Fizz = fizz;
            return View();
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}