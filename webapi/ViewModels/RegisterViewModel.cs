using System.ComponentModel.DataAnnotations;
namespace webapi.ViewModels
{
    public class RegisterViewModel

        {

            [Required(ErrorMessage = "El correo electronico no puede quedar en blanco")]
            [EmailAddress]
            [Display(Name = "Correo Electronico")]
            public string Mail { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Introduzca password")]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirme password")]
            [Compare("Password", ErrorMessage = "La contraseña y confirmación no coinciden")]
            public string ConfirmPassword { get; set; }

            [Required]
            public DateTime Birthday { get; set; }

     }
}
