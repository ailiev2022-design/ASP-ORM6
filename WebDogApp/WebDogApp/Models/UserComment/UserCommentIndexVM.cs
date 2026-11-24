using System.ComponentModel.DataAnnotations;

namespace WebDogApp.Models.UserComment
{
    public class UserCommentIndexVM
    {
        public int Id { get; set; }

        [Display(Name = "Потребител")]
        public string UserName { get; set; } = null!;

        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;

        [Display(Name = "Коментар")]
        public string Comment { get; set; } = null!;
    }
}
