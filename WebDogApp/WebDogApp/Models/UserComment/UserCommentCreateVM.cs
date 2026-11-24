using System.ComponentModel.DataAnnotations;

namespace WebDogApp.Models.UserComment
{
    public class UserCommentCreateVM
    {
        [Required(ErrorMessage = "Потребителското име е задължително.")]
        [Display(Name = "Потребителско име")]
        [StringLength(50, MinimumLength = 2)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Имейл адресът е задължителен.")]
        [EmailAddress(ErrorMessage = "Невалиден имейл адрес.")]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Коментарът не може да бъде празен.")]
        [Display(Name = "Коментар")]
        [StringLength(500, MinimumLength = 3)]
        public string Comment { get; set; } = null!;
    }
}
