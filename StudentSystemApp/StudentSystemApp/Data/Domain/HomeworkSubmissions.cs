using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class HomeworkSubmissions
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string ContentType { get; set; } = null!;

        public DateTime SubmissionTime { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Students Students { get; set; }

        [Required]
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }

       



    }
}
