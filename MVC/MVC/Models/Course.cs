﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public string Type { get; set; }
    }
}
