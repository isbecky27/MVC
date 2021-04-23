using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Repos;
using MVC.Services;

namespace MVC.Controllers
{
    public class CourseManagementController : Controller
    {
        private readonly ICourseRepo _courseRepo;
        private readonly ICurrentCourseService _currentCourseService;
        private readonly IMyCourseService _myCourseService;

        public CourseManagementController(ICourseRepo courseRepo, ICurrentCourseService currentCourseService, IMyCourseService myCourseService)
        {
            _courseRepo = courseRepo;
            _currentCourseService = currentCourseService;
            _myCourseService = myCourseService;
        }

        public IActionResult Index()
        {
            ViewBag.Courses = _courseRepo.GetCourses().ToList();
            ViewBag.CurrentCourses = _currentCourseService.GetCurrentCourses();

            return View("Index");
        }

        public IActionResult AddCourse(CurrentCourse course)
        {
            if (!ModelState.IsValid)
                return View("Index", course);
            
            _currentCourseService.AddCourse(course);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCourse(int courseNo)
        {
            _currentCourseService.DeleteCourse(courseNo);
            _myCourseService.DeleteCourse(courseNo);
            return RedirectToAction("Index");
        }
    }
}
