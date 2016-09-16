﻿using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIMVC5.Models;
using KendoUIMVC5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace KendoUIMVC5.Controllers
{
    public class HomeController : Controller
    {
        public static List<Person> persons = new List<Person>();

        static HomeController()
        {
            persons.Add(new Person { PersonID = 1, Name = "John", BirthDate = new DateTime(1968, 6, 26), Designation = 2 });
            persons.Add(new Person { PersonID = 2, Name = "Sara", BirthDate = new DateTime(1974, 9, 13), Designation = 4 });
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();
        }


        public ActionResult GetPerson(int id)
        {
            var p = persons.Where(x => x.PersonID == id).First();

            return View(p);
        }

        public ActionResult GetPersons([DataSourceRequest] DataSourceRequest dsRequest)
        {
            var result = persons.ToDataSourceResult(dsRequest);
            return Json(result);
        }

        public ActionResult UpdatePerson([DataSourceRequest] DataSourceRequest dsRequest, Person person)
        {
            if (person != null && ModelState.IsValid)
            {
                var toUpdate = persons.FirstOrDefault(p => p.PersonID == person.PersonID);
                TryUpdateModel(toUpdate);
            }

            return Json(new[] { person }.ToDataSourceResult(dsRequest, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreatePerson([DataSourceRequest] DataSourceRequest dsRequest, Person person)
        {
            if (person != null && ModelState.IsValid)
            {
                person.PersonID = persons.ToList().Count + 1;
                persons.Add(person);
            }

            return Json(new[] { person }.ToDataSourceResult(dsRequest, ModelState));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }

        public JsonResult GetDesignation()
        {
            System.Threading.Thread.Sleep(1000);
            return Json(new DesignationRepositories().GetDesignation(), JsonRequestBehavior.AllowGet);
        }
    }
}