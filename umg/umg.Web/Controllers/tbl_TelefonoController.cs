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
    public class tbl_TelefonoController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_TelefonoController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Telefono/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Telefono>>> Gettbl_Telefono()
        {
            return await _context.tbl_Telefonos.ToListAsync();
        }

        // GET api/tbl_Telefono/2
        [HttpGet("{idTelefono}")]

        public async Task<ActionResult<tbl_Telefono>> Gettbl_Telefono(int id)
        {
            var tbl_Telefono = await _context.tbl_Telefonos.FindAsync(id);

            if (tbl_Telefono == null)
            {
                return NotFound();
            }

            return tbl_Telefono;
        }


        // put api/tbl_Telefono/2 
        [HttpPut("idTelefono")]
        public async Task<IActionResult> puttbl_Telefono(int id, tbl_Telefono tbl_Telefono)
        {
            if (id != tbl_Telefono.idTelefono)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Telefono).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_TelefonoExists(id))
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

        //POst api/tbl_Telefono
        [HttpPost]
        public async Task<ActionResult<tbl_Telefono>> Posttbl_Telefono(tbl_Telefono tbl_Telefono)
        {
            _context.tbl_Telefonos.Add(tbl_Telefono);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Telefono", new { id = tbl_Telefono.idTelefono }, tbl_Telefono);
        }

        //Delete Api/tbl_Telefono / 2 

        [HttpDelete("idTelefono")]
        public async Task<ActionResult<tbl_Telefono>> Deletetbl_Telefono(int id)
        {
            var tbl_Telefono = await _context.tbl_Telefonos.FindAsync(id);

            if (tbl_Telefono == null)
            {
                return NotFound();
            }

            _context.tbl_Telefonos.Remove(tbl_Telefono);
            await _context.SaveChangesAsync();

            return tbl_Telefono;
        }

        private bool tbl_TelefonoExists(int id)
        {
            return _context.tbl_Telefonos.Any(e => e.idTelefono == id);
        }
    }

}




