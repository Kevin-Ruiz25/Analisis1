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
    public class tbl_PersonaController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_PersonaController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Persona/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Persona>>> Gettbl_Persona()
        {
            return await _context.tbl_Personas.ToListAsync();
        }

        // GET api/tbl_Persona/2
        [HttpGet("{idPersona}")]

        public async Task<ActionResult<tbl_Persona>> Gettbl_Persona(int id)
        {
            var tbl_Persona = await _context.tbl_Personas.FindAsync(id);

            if (tbl_Persona == null)
            {
                return NotFound();
            }

            return tbl_Persona;
        }


        // put api/tbl_Persona/2 
        [HttpPut("idPersona")]
        public async Task<IActionResult> puttbl_Persona(int id, tbl_Persona tbl_Persona)
        {
            if (id != tbl_Persona.idPersona)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_PersonaExists(id))
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

        //POst api/tbl_Persona
        [HttpPost]
        public async Task<ActionResult<tbl_Persona>> Posttbl_Persona(tbl_Persona tbl_Persona)
        {
            _context.tbl_Personas.Add(tbl_Persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Persona", new { id = tbl_Persona.idPersona }, tbl_Persona);
        }

        //Delete Api/Persona/ 2 

        [HttpDelete("idPersona")]
        public async Task<ActionResult<tbl_Persona>> Deletetbl_Persona(int id)
        {
            var tbl_Persona = await _context.tbl_Personas.FindAsync(id);

            if (tbl_Persona == null)
            {
                return NotFound();
            }

            _context.tbl_Personas.Remove(tbl_Persona);
            await _context.SaveChangesAsync();

            return tbl_Persona;
        }

        private bool tbl_PersonaExists(int id)
        {
            return _context.tbl_Personas.Any(e => e.idPersona == id);
        }
    }

}




