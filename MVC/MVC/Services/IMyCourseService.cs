using System.Collections.Generic;
using MVC.Models;

namespace MVC.Services
{
    public interface IMyCourseService
    {
        List<CurrentCourse> GetMyCourses();
        List<int> GetMyCoursesNo();
        void AddCourse(CurrentCourse course);
        void DeleteCourse(int courseNo);
    }
}