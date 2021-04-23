using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;
using MVC.Repos;

namespace MVC.Services
{
    public class MyCourseService : IMyCourseService
    { 
        private readonly List<CurrentCourse> _myCourses = new List<CurrentCourse>();

        public List<CurrentCourse> GetMyCourses()
        {
            return _myCourses;
        }

        public List<int> GetMyCoursesNo()
        {
            return _myCourses.Select(o=>o.Id).ToList();
        }

        public void AddCourse(CurrentCourse course)
        {
            _myCourses.Add(course);
        }

        public void DeleteCourse(int courseNo)
        {
            _myCourses.Remove(_myCourses.FirstOrDefault(o=>o.CourseNo==courseNo));
        }
    }
}
