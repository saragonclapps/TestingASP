using System;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new Models.School("Pepe pepito-school !!", 2005, TypesSchool.ElementarySchool)
            {
                Country = "Colombia",
                City = "Bogota",
                Address = "Calle 77 C numero 109 A 22",
            };
            
            ViewBag.AnyThingOne = "1- object of bag!!";
            ViewBag.AnyThingTwo = "2-fasdfa object of bag!!";
            
            return View(school);
        }
    }
}