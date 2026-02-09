using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStore.Api.Data;
using TechStore.Api.Models;
using BCrypt.Net;

namespace TechStore.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsuariosController(AppDbContext context)
    {
        _context = context;
    }

    // CREATE (Registro) - Salva o usuário com senha criptografada
    [HttpPost("registrar")]
    public async Task<ActionResult> Registrar(Usuario user)
    {
        // Transforma a senha em Hash (Segurança)
        user.SenhaHash = BCrypt.Net.BCrypt.HashPassword(user.SenhaHash);
        
        _context.Usuarios.Add(user);
        await _context.SaveChangesAsync();
        
        return Ok(new { mensagem = "Usuário criado com sucesso!" });
    }

    // READ (Login) - Verifica se a senha bate para deixar entrar
    [HttpPost("login")]
    public async Task<ActionResult> Login(Usuario loginData)
    {
        var user = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Username == loginData.Username);

        if (user == null || !BCrypt.Net.BCrypt.Verify(loginData.SenhaHash, user.SenhaHash))
        {
            return Unauthorized(new { mensagem = "Usuário ou senha inválidos." });
        }

        return Ok(new { mensagem = "Login realizado com sucesso!" });
    }
}