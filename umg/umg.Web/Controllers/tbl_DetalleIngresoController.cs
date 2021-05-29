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
    public class tbl_DetalleIngresoController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public   tbl_DetalleIngresoController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Detalle_Ventas_/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_detalleIngreso>>> GetTbl_detalleIngreso()
        {
            return await _context.tbl_DetalleIngresos.ToListAsync();
        }

        // GET api/tbl_detalleIngreso/2
        [HttpGet("{idDetalleIngreso}")]

        public async Task<ActionResult<tbl_detalleIngreso>> Gettbl_detalleingreso(int id)
        {
            var tbl_detalleIngreso = await _context.tbl_DetalleIngresos.FindAsync(id);

            if (tbl_detalleIngreso == null)
            {
                return NotFound();
            }

            return tbl_detalleIngreso;
        }


        // put api/tbl_detalleIngreso/2 
        [HttpPut("idDetalleIngreso")]
        public async Task<IActionResult> puttbl_detalleIngreso(int id, tbl_detalleIngreso tbl_detalleIngreso)
        {
            if (id != tbl_detalleIngreso.idDetalleIngreso)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_detalleIngreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_detalleIngresoExists(id))
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

        //POst api/tbl_detalleIngreso/2
        [HttpPost]
        public async Task<ActionResult<tbl_detalleIngreso>> Posttbl_detalleIngreso(tbl_detalleIngreso tbl_detalleIngreso)
        {
            _context.tbl_DetalleIngresos.Add(tbl_detalleIngreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_detalleIngreso", new { id = tbl_detalleIngreso.idDetalleIngreso }, tbl_detalleIngreso);
        }

        //Delete Api/tbl_detalleIngreso / 2 

        [HttpDelete("idDetalleIngreso")]
        public async Task<ActionResult<tbl_detalleIngreso>> Deletetbl_detalleIngreso(int id)
        {
            var tbl_detalleIngreso = await _context.tbl_DetalleIngresos.FindAsync(id);

            if (tbl_detalleIngreso == null)
            {
                return NotFound();
            }

            _context.tbl_DetalleIngresos.Remove(tbl_detalleIngreso);
            await _context.SaveChangesAsync();

            return tbl_detalleIngreso;
        }

        private bool tbl_detalleIngresoExists(int id)
        {
            return _context.tbl_DetalleIngresos.Any(e => e.idDetalleIngreso == id);
        }
    }

}




