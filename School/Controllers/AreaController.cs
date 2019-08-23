using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            var area = new Models.Area()
            {
                Name = "Computer's science",
                UniqueId = Guid.NewGuid().ToString()
            };
            
            return View("Index",area);  
        }
        
        public IActionResult MultiAreas()
        {
            var areas = new List<Models.Area>(){
                new Models.Area{Name="Math", UniqueId = Guid.NewGuid().ToString()} ,
                new Models.Area{Name="English", UniqueId = Guid.NewGuid().ToString()},
                new Models.Area{Name="Spanish", UniqueId = Guid.NewGuid().ToString()},
                new Models.Area{Name="Programming", UniqueId = Guid.NewGuid().ToString()}
            };
            
            return View("MultiAreas",areas);  
        }
    }
}