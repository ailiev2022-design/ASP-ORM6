using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Courses
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }
       
        public virtual IEnumerable<Resources> Resource { get; set; } = new List<Resources>();
        public virtual IEnumerable<StudentCourses> StudentCourse { get; set; } = new List<StudentCourses>();
        public virtual IEnumerable<HomeworkSubmissions> HomeworkSubmissions { get; set; } = new List<HomeworkSubmissions>();

    }
}
