using System.ComponentModel.DataAnnotations;

namespace AppCitas.DTOs;

public class LoginDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }

}
