using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodolistU.Models;

namespace TodolistU.Controllers
{
    public class HomeController : Controller
    {
        private static List<Uppgift> todoList = new List<Uppgift>();

        public IActionResult Index()
        {
            return View(todoList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Uppgift uppgift)
        {
            if (ModelState.IsValid)
            {
                todoList.Add(uppgift);
                return RedirectToAction("Index");
            }
            return View(uppgift);
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            if (id >= 0 && id < todoList.Count)
            {
                // Markera uppgiften som utförd
                todoList[id].ÄrKlar = true;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id >= 0 && id < todoList.Count)
            {
                // Ta bort uppgiften från listan
                todoList.RemoveAt(id);
            }
            return RedirectToAction("Index");
        }

    }
}
