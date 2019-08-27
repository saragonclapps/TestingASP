using System;
using System.Collections.Generic;

namespace School.Models
{
    public class School : SchoolBase, IPlace
    {
        public int FundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public TypesSchool TypeSchool { get; set; }
        public List<Course> Courses { get; set; }
        
//        public School(string name, int year) => (Name, FundationYear) = (name, year);
        
//        public School(string name, int year, TypesSchool type, string country = "", string city = "") : base()
//        {
//            (Name, FundationYear) = (name, year);
//            Country = country;
//            City = city;
//        }

        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {TypeSchool} {Environment.NewLine} Pais: {Country}, Ciudad:{City}";
        }

        public void CleanPlace()
        {
            throw new NotImplementedException();
        }
    }
}