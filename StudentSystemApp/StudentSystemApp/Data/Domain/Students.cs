using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Students
    {
        public int Id { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(10)]
        [MinLength(10)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public DateTime RegisterdOn { get; set; }

        public DateTime Birthday { get; set; }

        public virtual IEnumerable<HomeworkSubmissions> HomeworkSubmissions { get; set; } = new List<HomeworkSubmissions>();

        public virtual IEnumerable<StudentCourses> StudentCourses { get; set; } = new List<StudentCourses>();
    }
}
