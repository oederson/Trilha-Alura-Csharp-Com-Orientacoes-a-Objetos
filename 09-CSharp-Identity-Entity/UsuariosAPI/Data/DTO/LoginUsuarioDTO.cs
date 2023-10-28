using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.DTO
{
    public class LoginUsuarioDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }    
    }
}
