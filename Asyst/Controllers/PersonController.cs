using Asyst.Models;
using Asyst.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asyst.Controllers
{
    public class PersonController : Controller
    {
        private IPersonRepository repo;

        public PersonController(IPersonRepository repository)
        {
            repo = repository;
        }
        // GET: PersonController
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.Get(id));
        }

        // GET: PersonController/Create
        public ActionResult Create(string Name, string Email)
        {

            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var person = new Person
                {
                    Name = collection["Name"],
                    Email = collection["Email"]
                };
                repo.Add(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var updatedPerson = new Person
                {
                    Name = collection["Name"],
                    Email = collection["Email"]
                };
                repo.Update(id, updatedPerson);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(repo.Get(id));
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                repo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
