using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domain
{
    public class Resources
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public string Url { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string ResourceType { get; set; } = null!;
        [Required]
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }

        
    }
}
