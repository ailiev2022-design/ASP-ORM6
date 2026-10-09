using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class StudentCourses
    {
        public int Id { get; set; }

        [Required]
        public int StudentsId { get; set; }
        public virtual Students Students { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }

       
    }
}
