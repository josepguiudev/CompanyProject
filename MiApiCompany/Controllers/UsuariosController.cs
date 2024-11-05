using MiApiCompany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MiApiCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        // Inyección de dependencias para obtener el DbContext
        public UsuariosController(ApiDbContext context)
        {
            _context = context;
        }

        // Obtener todos los usuarios
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _context.Usuarios.ToListAsync());  // Obtener todos los usuarios desde la base de datos
        }

        // Obtener un usuario por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        // Obtener un usuario por su email
        [HttpGet("email/{email}")]
        public async Task<ActionResult<Usuario>> GetByEmail(string email)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(
                u => u.email.ToLower() == email.ToLower()
                );  // Ignora mayúsculas/minúsculas

            if (usuario == null)
                return NotFound(new { Message = "Usuario no encontrado" });

            return Ok(usuario);
        }

        // Crear un nuevo usuario
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User nuevoUsuario)
        {
            _context.Usuarios.Add(nuevoUsuario);
            await _context.SaveChangesAsync();  // Guardar los cambios en la base de datos
            return CreatedAtAction(nameof(Get), new { id = nuevoUsuario.id }, nuevoUsuario);
        }

        // Actualizar un usuario existente
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] User usuarioActualizado)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) return NotFound();

            usuario.name = usuarioActualizado.name;
            usuario.first_surname = usuarioActualizado.first_surname;
            usuario.second_surname = usuarioActualizado.second_surname;
            usuario.phone = usuarioActualizado.phone;
            usuario.email = usuarioActualizado.email;
            usuario.dni = usuarioActualizado.dni;
            usuario.is_admin = usuarioActualizado.is_admin;
            usuario.is_active = usuarioActualizado.is_active;
            usuario.password = usuarioActualizado.password;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Eliminar un usuario
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) return NotFound();

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

    // Modelo de usuario
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    // Modelo de usuario enano
    public class Enano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
