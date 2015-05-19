using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinahProject.Models;

namespace FinahProject.Controllers
{
    public class EnquiryController : Controller
    {
        //
        // GET: /Enquiry/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Enquiry/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Enquiry/Create

        public ActionResult Create()
        {


            return View();
        }

        //
        // POST: /Enquiry/Create

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

        //
        // GET: /Enquiry/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Enquiry/Edit/5

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

        //
        // GET: /Enquiry/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Enquiry/Delete/5

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

        public ActionResult titleForm()
        {
            EnquiryTitelForm form = new EnquiryTitelForm();
            //form.ListItems = new List<SelectListItem>();
            //form.ListItems.Add(new SelectListItem
            //{
            //    Text = "Patiënt",
            //    Value = "Patiënt"
            //});
            //form.ListItems.Add(new SelectListItem
            //{
            //    Text = "Mantelzorger",
            //    Value = "Mantelzorger"
            //});
            return View(form);
        }

    }
}
