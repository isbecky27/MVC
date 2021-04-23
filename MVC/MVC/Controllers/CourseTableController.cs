using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Repos;
using MVC.Services;

namespace MVC.Controllers
{
    public class CourseTableController : Controller
    {
        private readonly ICourseRepo _courseRepo;
        private readonly ICurrentCourseService _currentCourseService;
        private readonly IMyCourseService _myCourseService;

        public CourseTableController(ICourseRepo courseRepo, ICurrentCourseService currentCourseService, IMyCourseService myCourseService)
        {
            _courseRepo = courseRepo;
            _currentCourseService = currentCourseService;
            _myCourseService = myCourseService;
        }
        
        public ActionResult Index()
        {
            var currentCourses = _currentCourseService.GetCurrentCourses();
            ViewBag.Courses = _courseRepo.GetCourses();
            ViewBag.MyCourses = _myCourseService.GetMyCourses();
            return View("Index", currentCourses);
        }

        public ActionResult AddCourse(int courseNo)
        {
            var course = _currentCourseService.GetCurrentCourseByCourseNo(courseNo);
            _currentCourseService.UpdateRegisteredNumbersByCourseNo(courseNo);
            _myCourseService.AddCourse(course);
            return RedirectToAction("Index", "MyCourse");
        }
    }
}
