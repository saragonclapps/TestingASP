using System;
using System.Collections.Generic;

namespace School.Models
{
    public class Course : SchoolBase, IPlace
    {
        public TypesWorkingDay WorkingDay { get; set; }
        public List<Area> Areas{ get; set; }
        public List<Student> Students{ get; set; }
        public string Address { get; set; }

        public void CleanPlace()
        {
            throw new NotImplementedException();
        }
    }
}