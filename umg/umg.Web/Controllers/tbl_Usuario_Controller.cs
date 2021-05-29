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
    public class tbl_Usuario_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_Usuario_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_usuario_/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_usuario_>>> GetTbl_usuario()
        {
            return await _context.tbl_usuarios_.ToListAsync();
        }

        // GET api/tbl_usuario/2
        [HttpGet("{idUsuario_}")]

        public async Task<ActionResult<tbl_usuario_>> Gettbl_usuario_(int id)
        {
            var tbl_usuario_ = await _context.tbl_usuarios_.FindAsync(id);

            if (tbl_usuario_ == null)
            {
                return NotFound();
            }

            return tbl_usuario_;
        }


        // put api/tbl_usuario/2 
        [HttpPut("idUsuario_")]
        public async Task<IActionResult> puttbl_usuario_(int id, tbl_usuario_ tbl_usuario_)
        {
            if (id != tbl_usuario_.idUsuario_)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_usuario_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_usuario_Exists(id))
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

        //POst api/tbl_usuario_
        [HttpPost]
        public async Task<ActionResult<tbl_usuario_>> Posttbl_usuario_(tbl_usuario_ tbl_usuario_)
        {
            _context.tbl_usuarios_.Add(tbl_usuario_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_usuario_", new { id = tbl_usuario_.idUsuario_ }, tbl_usuario_);
        }

        //Delete Api/tbl_usuario / 2 

        [HttpDelete("idUsuario_")]
        public async Task<ActionResult<tbl_usuario_>> Deletetbl_usuario_(int id)
        {
            var tbl_usuario_ = await _context.tbl_usuarios_.FindAsync(id);

            if (tbl_usuario_ == null)
            {
                return NotFound();
            }

            _context.tbl_usuarios_.Remove(tbl_usuario_);
            await _context.SaveChangesAsync();

            return tbl_usuario_;
        }

        private bool tbl_usuario_Exists(int id)
        {
            return _context.tbl_usuarios_.Any(e => e.idUsuario_ == id);
        }
    }

}




