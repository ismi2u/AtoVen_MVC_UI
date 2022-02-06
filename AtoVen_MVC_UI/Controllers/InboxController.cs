using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Controllers
{
    public class InboxController : Controller
    {
        // GET: InboxController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InboxController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InboxController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InboxController/Create
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

        // GET: InboxController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InboxController/Edit/5
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

        // GET: InboxController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InboxController/Delete/5
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
