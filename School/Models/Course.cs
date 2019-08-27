using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Course : SchoolBase, IPlace
    {
        [Required]
        [MaxLength(7)]
        public override string Name { get; set; }
        public TypesWorkingDay WorkingDay { get; set; }
        public List<Area> Areas{ get; set; }
        public List<Student> Students{ get; set; }
        
        [Display(Prompt = "The address destination", Name = "ADDRESS!")]
        [MinLength(5, ErrorMessage = "hey bro i need more the 5 letters")]
        [Required(ErrorMessage = "The address is the side in City haha huhu")]
        public string Address { get; set; }
        public string SchoolId { get; set; }
        public School School { get; set; }
    }
}