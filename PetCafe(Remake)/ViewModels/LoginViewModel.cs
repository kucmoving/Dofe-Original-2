using System.ComponentModel.DataAnnotations;

namespace PetCafe_Remake_.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
<<<<<<< HEAD
        [EmailAddress]
        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; set; }

=======
        [Required(ErrorMessage = "Email address is required")]

        public string EmailAddress { get; set; }
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
<<<<<<< HEAD

=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
}