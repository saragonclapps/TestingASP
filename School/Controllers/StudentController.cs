using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _context;
        
        public StudentController(SchoolContext context)
        {
            _context = context;
        }
        
//        public IActionResult Index(string id)
//        {
//            var student = _context.Students
//                .FirstOrDefault(c => c.Id == id);
//
//            return View("Index",student);
//        }    

        public IActionResult Index(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                var students = _context.Students;
                return View("MultiStudent",students); 
            }
            
            var student = _context.Students
                .FirstOrDefault(c => c.Id == id);

            return View("Index",student);
        }
        
        public IActionResult MultiStudent()
        {
            var listStudents = _context.Students;

            return View("MultiStudent",listStudents);
        }
    }
}