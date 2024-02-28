using System.ComponentModel.DataAnnotations;

namespace place2024.Models.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Le courriel est requis.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "La confirmation du mot de passe est requise.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Le mot de passe et sa confirmation ne concordent pas.")]
        public string ConfirmPassword { get; set; }
    }
}
