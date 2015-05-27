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
            form.ListItems = new List<SelectListItem>();
            foreach (var item in form.extraPersonList)
            {
                form.ListItems.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Name

                });

            }
            this.TempData["extraPersonList"] = form.ListItems;
            return View(form);
        }

        [HttpPost]
        public ActionResult AddPerson(EnquiryTitelForm form)
        {
            try
            {
                form.ListItems = (List<SelectListItem>)TempData["extraPersonList"];
                form.ListItems.Add(new SelectListItem { Text = form.extraPersonName , Value = form.extraPersonName});
                //foreach (var item in form.extraPersonList)
                //{
                //    form.ListItems.Add(new SelectListItem
                //    {
                //        Text = item.Name,
                //        Value = item.Name

                //    });

                //}
                this.TempData["extraPersonList"] = form.ListItems;
                return View("titleForm", form);
            }
            catch
            {
                return View(form);
            }
        }

        [HttpPost]
        public ActionResult RemovePerson(FormCollection form, EnquiryTitelForm model)
        {
            try

            {
                String[] splittedPersons = null;
                var selectedItems = form["extraPerson"];
                if (selectedItems.Contains(','))
                {
                    splittedPersons = selectedItems.Split(',');
                }
                //List<SelectListItem> removePersonsList = new List<SelectListItem>();
                model.ListItems = (List<SelectListItem>)TempData["extraPersonList"];
                List<SelectListItem> tempList = new List<SelectListItem>();
                foreach (var item in model.ListItems)
                {
                    tempList.Add(item);
                }
                foreach (var item in tempList)
                {
                    foreach (var split in splittedPersons)
                    {
                        if (item.Text == split)
                        {
                            model.ListItems.Remove(item);
                        }
                    }
                    
                }
                        
               
            
               // model.ListItems.RemoveAll(x => removePersonsList.Contains(x));
                
                this.TempData["extraPersonList"] = model.ListItems;
                return View("titleForm", model);
            }
            catch (Exception)
            {

                return View(form);
            }
        }
    }
}
