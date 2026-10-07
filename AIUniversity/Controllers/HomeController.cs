using Microsoft.AspNetCore.Mvc;
using AIUniversity.Models;

namespace AIUniversity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Lecturer lecturer = new Lecturer
            {
                LecturerId = 1,
                Name = "Dr. Sarah Kim",
                Email = "sarah@aiuniversity.edu",
                Specialisation = "Artificial Intelligence"
            };

            return View(lecturer);
        }
    }
}