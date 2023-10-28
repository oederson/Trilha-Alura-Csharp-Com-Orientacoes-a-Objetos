﻿using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Service;

namespace UsuariosAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioService _usuarioService;

    public UsuarioController(UsuarioService cadastroService)
    {
        _usuarioService = cadastroService;
    }

    [HttpPost("Cadastro")]
    public async Task<IActionResult> CadastraUsuario(CriarUsuarioDTO dto)
    {
        await _usuarioService.Cadastra(dto);
        return Ok("Usuário cadastrado com sucesso");
    }
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginUsuarioDTO dto)
    {
        var token = await _usuarioService.Login(dto);
        return Ok(token);
    }
}
