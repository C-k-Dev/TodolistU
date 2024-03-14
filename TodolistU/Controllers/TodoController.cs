using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodolistU.Models; 

namespace TodolistU.Controllers
{
    public class TodoController : Controller
    {
        private List<Uppgift> todoList = new List<Uppgift>(); // Flytta deklarationen hit

        public IActionResult Index()
        {
            var uppgiftsLista = new List<Uppgift>(); // Skapa en lista av Uppgift-objekt
            return View(uppgiftsLista);
        }

        public IActionResult Complete(int id)
        {
            if (id >= 0 && id < todoList.Count)
            {
                todoList.RemoveAt(id);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id >= 0 && id < todoList.Count)
            {
                todoList.RemoveAt(id);
            }
            return RedirectToAction("Index");
        }
    }
}
