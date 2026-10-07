using Microsoft.AspNetCore.Mvc;
using AIUniversity.Models;
using System.Collections.Generic;

namespace AIUniversity.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            List<Course> courses = new List<Course>
            {
                new Course
                {
                    CourseId = 1,
                    CourseName = "Introduction to AI",
                    Description = "Introduction to Artificial Intelligence",
                    Credit = 3
                },

                new Course
                {
                    CourseId = 2,
                    CourseName = "Machine Learning",
                    Description = "Fundamentals of Machine Learning",
                    Credit = 3
                },

                new Course
                {
                    CourseId = 3,
                    CourseName = "Advanced Web Development",
                    Description = "ASP.NET Core MVC Web Development",
                    Credit = 3
                }
            };

            return View(courses);
        }
    }
}