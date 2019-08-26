using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Course : SchoolBase, IPlace
    {
        [Required]
        public override string Name { get; set; }
        public TypesWorkingDay WorkingDay { get; set; }
        public List<Area> Areas{ get; set; }
        public List<Student> Students{ get; set; }
        public string Address { get; set; }
        public string SchoolId { get; set; }
        public School School { get; set; }
    }
}