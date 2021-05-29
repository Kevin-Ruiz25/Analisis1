using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umg.Datos;
using umg.Entidades.Ventas;

namespace umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_IngresoController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_IngresoController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Ingreso/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Ingreso>>> GetTbl_detalleIngreso()
        {
            return await _context.tbl_Ingresos.ToListAsync();
        }

        // GET api/tbl_Ingreso/2
        [HttpGet("{idIngreso}")]

        public async Task<ActionResult<tbl_Ingreso>> Gettbl_Ingreso(int id)
        {
            var tbl_Ingreso = await _context.tbl_Ingresos.FindAsync(id);

            if (tbl_Ingreso == null)
            {
                return NotFound();
            }

            return tbl_Ingreso;
        }


        // put api/tbl_Ingreso/2 
        [HttpPut("idIngreso")]
        public async Task<IActionResult> puttbl_Ingreso(int id, tbl_Ingreso tbl_Ingreso)
        {
            if (id != tbl_Ingreso.idIngreso)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Ingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_IngresoExists(id))
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

        //POst api/tbl_Ingreso/2
        [HttpPost]
        public async Task<ActionResult<tbl_Ingreso>> Posttbl_Ingreso(tbl_Ingreso tbl_Ingreso)
        {
            _context.tbl_Ingresos.Add(tbl_Ingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Ingreso", new { id = tbl_Ingreso.idIngreso }, tbl_Ingreso);
        }

        //Delete Api/tbl_Ingreso / 2 

        [HttpDelete("idIngreso")]
        public async Task<ActionResult<tbl_Ingreso>> Deletetbl_Ingreso(int id)
        {
            var tbl_Ingreso = await _context.tbl_Ingresos.FindAsync(id);

            if (tbl_Ingreso == null)
            {
                return NotFound();
            }

            _context.tbl_Ingresos.Remove(tbl_Ingreso);
            await _context.SaveChangesAsync();

            return tbl_Ingreso;
        }

        private bool tbl_IngresoExists(int id)
        {
            return _context.tbl_Ingresos.Any(e => e.idIngreso == id);
        }
    }

}




