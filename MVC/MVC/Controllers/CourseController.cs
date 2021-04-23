using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Repos;
using MVC.Services;

namespace MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepo _courseRepo;

        public CourseController(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        
        public ActionResult Index()
        {
            var courses = _courseRepo.GetCourses();
            return View("Index", courses);
        }
    }
}
