using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Models
{
    public class LoginModel
    {
        [Required]
        public string Correo { get; set; }

        [Required]
        public string Password { get; set; }
    }
}