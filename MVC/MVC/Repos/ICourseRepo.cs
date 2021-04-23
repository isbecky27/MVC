using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Repos
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetCourses();
        public Course GetCourseById(int id);
    }
}
