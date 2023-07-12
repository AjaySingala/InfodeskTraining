using StandardWebApi.Models;
using StandardWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StandardWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";


            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.Title = "Details Page";
            // db code here.

            var customer = new Customer();
            customer.Id = id;
            customer.Firstname = "John";
            customer.Lastname = "Smith";

            return View(customer);
        }

    }
}
