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
    public class tbl_RolController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_RolController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Rol/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Rol>>> Gettbl_Rol()
        {
            return await _context.tbl_Rols.ToListAsync();
        }

        // GET api/tbl_Rol/2
        [HttpGet("{IdRol}")]

        public async Task<ActionResult<tbl_Rol>> Gettbl_Rol(int id)
        {
            var tbl_Rol = await _context.tbl_Rols.FindAsync(id);

            if (tbl_Rol == null)
            {
                return NotFound();
            }

            return tbl_Rol;
        }


        // put api/tbl_Rol/2 
        [HttpPut("IdRol")]
        public async Task<IActionResult> puttbl_Rol(int id, tbl_Rol tbl_Rol)
        {
            if (id != tbl_Rol.IdRol)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_RolExists(id))
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

        //POst api/tbl_Rol
        [HttpPost]
        public async Task<ActionResult<tbl_Rol>> Posttbl_Rol(tbl_Rol tbl_Rol)
        {
            _context.tbl_Rols.Add(tbl_Rol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Rol", new { id = tbl_Rol.IdRol },tbl_Rol);
        }

        //Delete Api/tbl_Rol/ 2 

        [HttpDelete("IdRol")]
        public async Task<ActionResult<tbl_Rol>> Deletetbl_Rol(int id)
        {
            var tbl_Rol = await _context.tbl_Rols.FindAsync(id);

            if (tbl_Rol == null)
            {
                return NotFound();
            }

            _context.tbl_Rols.Remove(tbl_Rol);
            await _context.SaveChangesAsync();

            return tbl_Rol;
        }

        private bool tbl_RolExists(int id)
        {
            return _context.tbl_Rols.Any(e => e.IdRol == id);
        }
    }

}




