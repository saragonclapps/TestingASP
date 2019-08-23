using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            var area = new Area{
                Name = "Computer's science",
                UniqueId = Guid.NewGuid().ToString()
            };
            
            return View("Index",area);
        }
        
        public IActionResult MultiArea()
        {
            var areas = new List<Area>{
                new Area{Name="Math", UniqueId = Guid.NewGuid().ToString()} ,
                new Area{Name="English", UniqueId = Guid.NewGuid().ToString()},
                new Area{Name="Spanish", UniqueId = Guid.NewGuid().ToString()},
                new Area{Name="Programming", UniqueId = Guid.NewGuid().ToString()}
            };
            
            return View("MultiArea",areas);  
        }
    }
}