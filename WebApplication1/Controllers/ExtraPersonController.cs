using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinahProject.Controllers
{
    public class ExtraPersonController : Controller
    {
        // GET: ExtraPerson
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExtraPerson/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExtraPerson/Create
        public ActionResult Create()
        {

            return RedirectToAction("../Enquiry/Create");
        }

        // POST: ExtraPerson/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
               
            
                return RedirectToAction("../Enquiry/Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: ExtraPerson/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExtraPerson/Edit/5
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

        // GET: ExtraPerson/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExtraPerson/Delete/5
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
