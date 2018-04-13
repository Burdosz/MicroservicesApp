using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationService.Models;

namespace NotificationService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var res = FetchBorrows().Result;
            Console.WriteLine(res);
            ViewData["borrow"] = res;
            return View();
        }

        private static async Task<string> FetchBorrows()
        {
            var client = new HttpClient();
            var httpLocalhostApiBorrows = "http://library:80/api/borrows/1";
            Console.WriteLine(httpLocalhostApiBorrows + " ________________()()()()()_____");
            var c = await client.GetStringAsync(httpLocalhostApiBorrows);
            
            return c;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}