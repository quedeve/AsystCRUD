using Asyst.Models;
using Asyst.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asyst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        //public void CreatePerson(string Name, string Email)
        //{
         
        //}

      

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        //public Person GetPerson(int ID)
        //{
        //    return repo.Get(ID);
        //}

        //public void UpdatePerson(int ID, string Name, string Email)
        //{
        //    var updatedPerson = new Person
        //    {
        //        Name = Name,
        //        Email = Email
        //    };
        //    repo.Update(ID, updatedPerson);
        //}

        //public void DeletePerson(int ID)
        //{
        //    repo.Delete(ID);
        //}
    }
}
