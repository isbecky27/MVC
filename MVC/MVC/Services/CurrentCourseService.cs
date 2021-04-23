using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;
using MVC.Repos;

namespace MVC.Services
{
    public class CurrentCourseService : ICurrentCourseService
    {
        private static int _courseNo = 1;

        private readonly List<CurrentCourse> _currentCourses = new List<CurrentCourse>()
        {
            new CurrentCourse()
            {
                CourseNo = 0,
                Id = 2,
                Time = "2EF",
                Teacher = "test",
                SizeLimits = 5
            }

        };
        
        public List<CurrentCourse> GetCurrentCourses()
        {
            return _currentCourses;
        }

        public CurrentCourse GetCurrentCourseByCourseNo(int courseNo)
        {
            return _currentCourses.FirstOrDefault(o => o.CourseNo == courseNo);
        }

        public void AddCourse(CurrentCourse course)
        {
            course.CourseNo = _courseNo;
            _courseNo += 1;
            _currentCourses.Add(course);
        }

        public void DeleteCourse(int courseNo)
        {
            _currentCourses.Remove(_currentCourses.FirstOrDefault(o => o.CourseNo == courseNo));
        }

        public void UpdateRegisteredNumbersByCourseNo(int courseNo)
        {
            _currentCourses.Where(o=> o.CourseNo == courseNo).ToList().ForEach(o => o.RegisteredNumbers += 1);
        }

        public void DeleteRegisteredNumbersByCourseNo(int courseNo)
        {
            _currentCourses.Where(o => o.CourseNo == courseNo).ToList().ForEach(o => o.RegisteredNumbers -= 1);
        }

    }
}
