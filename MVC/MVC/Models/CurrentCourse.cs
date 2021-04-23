using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class CurrentCourse
    {
        public int CourseNo { get; set; }
        [Required(ErrorMessage = "* Course Name is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "* Course Time is required")]
        public string Time { get; set; }
        [Required(ErrorMessage = "* Teacher is required")]
        public string Teacher { get; set; }
        [Required(ErrorMessage = "* SizeLimits is required")]
        [Range(1, 150, ErrorMessage = "* SizeLimits needs to be 1 to 150")]
        public int SizeLimits { get; set; }
        public int RegisteredNumbers { get; set; } = 0;
    }
}
