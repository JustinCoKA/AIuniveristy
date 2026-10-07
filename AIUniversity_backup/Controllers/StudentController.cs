using Microsoft.AspNetCore.Mvc;
using AIUniversity.Models;
using System.Collections.Generic;

namespace AIUniversity.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentId = 1,
                    Name = "John Smith",
                    Email = "john@aiuniversity.edu",
                    Major = "Artificial Intelligence"
                },

                new Student
                {
                    StudentId = 2,
                    Name = "Emma Wilson",
                    Email = "emma@aiuniversity.edu",
                    Major = "Machine Learning"
                },

                new Student
                {
                    StudentId = 3,
                    Name = "David Lee",
                    Email = "david@aiuniversity.edu",
                    Major = "Data Science"
                }
            };

            return View(students);
        }
    }
}