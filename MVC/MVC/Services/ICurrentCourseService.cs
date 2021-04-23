using System.Collections.Generic;
using MVC.Models;
using MVC.Repos;

namespace MVC.Services
{
    public interface ICurrentCourseService
    {
        List<CurrentCourse> GetCurrentCourses();
        CurrentCourse GetCurrentCourseByCourseNo(int index);
        void AddCourse(CurrentCourse course);
        void DeleteCourse(int courseNo);
        void UpdateRegisteredNumbersByCourseNo(int courseNo);
        void DeleteRegisteredNumbersByCourseNo(int courseNo);
    }
}