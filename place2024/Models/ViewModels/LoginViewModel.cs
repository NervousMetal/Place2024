using System.ComponentModel.DataAnnotations;

namespace place2024.Models.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Le courriel est requis.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}
