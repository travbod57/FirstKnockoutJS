using System.Collections.Generic;
using System.Web.Mvc;
using FirstKnockoutJS.Models;
using System;

namespace FirstKnockoutJS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Template()
        {
            Contact contact = new Contact() { Name = "Alex", Age = 29, Titles = new List<Title>() { new Title() { Id = 1, Name = "Mr" }, new Title() { Id = 2, Name = "Mrs" } } };
            return View(contact);
        }

        public ActionResult IntroBasicBindingsAndBehaviours()
        {
            return View();
        }

        public ActionResult HideAndShowElements()
        {
            return View();
        }

        public ActionResult ObservableCollections()
        {
            return View();
        }

        public ActionResult DynamicTemplateSwitch()
        {
            Contact contact = new Contact() { Name = "Alex", Age = 29, Titles = new List<Title>() { new Title() { Id = 1, Name = "Mr" }, new Title() { Id = 2, Name = "Mrs" } } };
            return View("~/Views/Home/Templates/DynamicTemplateSwitch.cshtml", contact);
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult KeepUpdatingBindingsFromJSON()
        {
            return View(new ClaimDetailsDto());
        }

        public JsonResult GetClaimDetails(int? fileId)
        {
            ClaimDetailsDto dto = new ClaimDetailsDto() { Client = "C1", Insured = "I1", TheDate = DateTime.Now };
            return Json(dto, JsonRequestBehavior.AllowGet);
        }

    }

    public class ClaimDetailsDto
    {
        public string Client { get; set; }
        public string Insured { get; set; }
        public DateTime? TheDate { get; set; }
    }
}
