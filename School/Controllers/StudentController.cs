using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student{
                Name = "Steve Sarmiento del perpetuo", 
                Id = Guid.NewGuid().ToString()
            };
            
            return View("Index",student);
        }
        
        public IActionResult MultiStudent()
        {
            const int MANY_STUDENTS = 30;
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] lastName1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

            var listStudents = 
                from n1 in name1
                from n2 in name2
                from a1 in lastName1
                select new Student{
                    Name = $"{n1} {n2} {a1}", 
                    Id = Guid.NewGuid().ToString()
                };

            return View("MultiStudent",listStudents.OrderBy(al => al.Id).Take(MANY_STUDENTS));
        }
    }
}