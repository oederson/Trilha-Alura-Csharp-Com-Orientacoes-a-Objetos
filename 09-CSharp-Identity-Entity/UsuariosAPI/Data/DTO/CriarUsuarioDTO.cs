﻿using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.DTO;

public class CriarUsuarioDTO
{
    [Required]
    public string  Username { get; set; }
    [Required]
    public DateTime DataNascimento { get; set;}
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }
}
