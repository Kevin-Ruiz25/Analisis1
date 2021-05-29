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

    public class tbl_Persona_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_Persona_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Persona_/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Persona_>>> Gettbl_Personas_()
        {
            return await _context.tbl_Personas_.ToListAsync();
        }

        // GET api/tbl_Persona/2
        [HttpGet("{idPersona_}")]

        public async Task<ActionResult<tbl_Persona_>> Gettbl_Personas_(int id)
        {
            var tbl_Persona_ = await _context.tbl_Personas_.FindAsync(id);

            if (tbl_Persona_ == null)
            {
                return NotFound();
            }

            return tbl_Persona_;
        }


        // put api/tbl_Persona_/2 
        [HttpPut("idPersona_")]
        public async Task<IActionResult> puttbl_Persona_(int id, tbl_Persona_ tbl_Persona_)
        {
            if (id != tbl_Persona_.idPersona_)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Persona_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_Persona_Exists(id))
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

        //POst api/tbl_Persona_
        [HttpPost]
        public async Task<ActionResult<tbl_Persona_>> Posttbl_Persona_(tbl_Persona_ tbl_Persona_)
        {
            _context.tbl_Personas_.Add(tbl_Persona_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Persona_", new { id = tbl_Persona_.idPersona_ }, tbl_Persona_);
        }

        //Delete Api/Persona_/ 2 

        [HttpDelete("idPersona_")]
        public async Task<ActionResult<tbl_Persona_>> Deletetbl_Persona_(int id)
        {
            var tbl_Persona_ = await _context.tbl_Personas_.FindAsync(id);

            if (tbl_Persona_ == null)
            {
                return NotFound();
            }

            _context.tbl_Personas_.Remove(tbl_Persona_);
            await _context.SaveChangesAsync();

            return tbl_Persona_;
        }

        private bool tbl_Persona_Exists(int id)
        {
            return _context.tbl_Personas_.Any(e => e.idPersona_ == id);
        }
    }

}

