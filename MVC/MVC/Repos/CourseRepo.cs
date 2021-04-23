using System;
using System.Collections.Generic;
using System.Linq;
using MVC.Models;

namespace MVC.Repos
{
    public class CourseRepo : ICourseRepo
    {
        private readonly List<Course> _courses = new List<Course>()
        {
            new Course
            {
                Id = 1,
                Name = "Object Oriented Programming",
                Credit = 3,
                Type = "Required"
            },
            new Course
            {
                Id = 2,
                Name = "Data Structure",
                Credit = 3,
                Type = "Required"
            },
            new Course
            {
                Id = 3,
                Name = "Algorithm",
                Credit = 3,
                Type = "Required"
            },
            new Course
            {
                Id = 4,
                Name = "Machine Learning",
                Credit = 2,
                Type = "Elective"
            },
            new Course
            {
                Id = 5,
                Name = "Introduction to Computer",
                Credit = 3,
                Type = "Required"
            },
            new Course
            {
                Id = 6,
                Name = "Image Processing",
                Credit = 3,
                Type = "Elective"
            }
        };

        public IEnumerable<Course> GetCourses()
        {
            return _courses;
        }

        public Course GetCourseById(int id)
        {
            return _courses.FirstOrDefault(x => x.Id == id);
        }

    }
}
