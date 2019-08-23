using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var school = ModelBaseSchool();
            var listStudents = CreateRandomListStudents();
            var listAreas = ModelListAreas();

            // modelBuilder only recives Arrays and a entity
            modelBuilder.Entity<School>().HasData(school);
            modelBuilder.Entity<Student>().HasData(listStudents.ToArray());
            modelBuilder.Entity<Area>().HasData(listAreas.ToArray());
        }

        private IEnumerable<Student> CreateRandomListStudents(int count = 30)
        {
            string[] name1 = {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás"};
            string[] name2 = {"Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro"};
            string[] lastName1 = {"Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};

            var listStudents =
                from n1 in name1
                from n2 in name2
                from a1 in lastName1
                select new Student
                {
                    Name = $"{n1} {n2} {a1}",
                    Id = Guid.NewGuid().ToString()
                };

            return listStudents.OrderBy(al => al.Id).Take(count);
        }

        private IEnumerable<Area> ModelListAreas()
        {
            return new List<Area>
            {
                new Area {Name = "Math", Id = Guid.NewGuid().ToString()},
                new Area {Name = "English", Id = Guid.NewGuid().ToString()},
                new Area {Name = "Spanish", Id = Guid.NewGuid().ToString()},
                new Area {Name = "Programming", Id = Guid.NewGuid().ToString()}
            };
        }

        private School ModelBaseSchool()
        {
            return new School
            {
                Name = "Pepe pepito-school !!",
                FundationYear = 2005,
                TypeSchool = TypesSchool.ElementarySchool,
                Country = "Colombia",
                City = "Bogota",
                Address = "Calle 77 C numero 109 A 22",
                Id = Guid.NewGuid().ToString()
            };
        }
    }
}