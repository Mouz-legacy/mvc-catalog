using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_953502_Strelets.Models;

namespace Web_953502_Strelets.Controllers
{
    public class HomeController : Controller
    {
        private List<ListDemoModel> listDemo;

        public HomeController()
        {
            this.listDemo = new List<ListDemoModel>()
            {
                new ListDemoModel() {ListItemValue = 1, ListItemText = "Item 1"},
                new ListDemoModel() { ListItemValue = 2, ListItemText = "Item 2" },
                new ListDemoModel() { ListItemValue = 3, ListItemText = "Item 3" }
            };
        }

        public ActionResult Index()
        {
            ViewData["Lst"] = new SelectList(this.listDemo, "ListItemValue", "ListItemText");
            ViewData["Text"] = "Лабораторная работа 2";
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
