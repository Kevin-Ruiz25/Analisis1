using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umg.Datos;
using umg.Entidades.Usuarios;

namespace umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_UsuarioController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_UsuarioController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_usuario/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_usuario>>> GetTbl_usuario()
        {
            return await _context.tbl_usuarios.ToListAsync();
        }

        // GET api/tbl_usuario/2
        [HttpGet("{idUsuario}")]

        public async Task<ActionResult<tbl_usuario>> Gettbl_usuario(int id)
        {
            var tbl_usuario = await _context.tbl_usuarios.FindAsync(id);

            if (tbl_usuario == null)
            {
                return NotFound();
            }

            return tbl_usuario;
        }


        // put api/tbl_usuario/2 
        [HttpPut("idUsuario")]
        public async Task<IActionResult> puttbl_usuario(int id, tbl_usuario tbl_usuario)
        {
            if (id != tbl_usuario.idUsuario)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_usuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }

            return NoContent();

        }

        //POst api/tbl_usuario
        [HttpPost]
        public async Task<ActionResult<tbl_usuario>> Posttbl_usuario(tbl_usuario tbl_usuario)
        {
            _context.tbl_usuarios.Add(tbl_usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_usuario", new { id = tbl_usuario.idUsuario }, tbl_usuario);
        }

        //Delete Api/tbl_usuario / 2 

        [HttpDelete("idUsuario")]
        public async Task<ActionResult<tbl_usuario>> Deletetbl_usuario(int id)
        {
            var tbl_usuario = await _context.tbl_usuarios.FindAsync(id);

            if (tbl_usuario == null)
            {
                return NotFound();
            }

            _context.tbl_usuarios.Remove(tbl_usuario);
            await _context.SaveChangesAsync();

            return tbl_usuario;
        }

        private bool tbl_usuarioExists(int id)
        {
            return _context.tbl_usuarios.Any(e => e.idUsuario == id);
        }
    }

}




