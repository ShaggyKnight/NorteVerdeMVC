using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorteVerde.Controllers
{
    public class roomsController : Controller
    {
        // GET: rooms
        public ActionResult Index()
        {
            return View();
        }

        // GET: rooms/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: rooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: rooms/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: rooms/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: rooms/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: rooms/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: rooms/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
