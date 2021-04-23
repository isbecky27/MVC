using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC.Repos;
using MVC.Services;

namespace MVC.Controllers
{
    public class MyCourseController : Controller
    {

        private readonly ICurrentCourseService _currentCourseService;
        private readonly IMyCourseService _myCourseService;
        private readonly ICourseRepo _courseRepo;

        public MyCourseController(ICourseRepo courseRepo, ICurrentCourseService currentCourseService, IMyCourseService myCourseService)
        {
            _courseRepo = courseRepo;
            _currentCourseService = currentCourseService;
            _myCourseService = myCourseService;
        }

        public IActionResult Index()
        {
            var classes = _myCourseService.GetMyCourses();
            ViewBag.Courses = _courseRepo.GetCourses().ToList();
            return View("Index", classes);
        }

        public IActionResult DeleteCourse(int courseNo)
        {
            _myCourseService.DeleteCourse(courseNo);
            _currentCourseService.DeleteRegisteredNumbersByCourseNo(courseNo);
            return RedirectToAction("Index", "MyCourse");
        }
    }
}
