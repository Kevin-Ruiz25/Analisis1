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
    public class tbl_VentasController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_VentasController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Ventas/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Venta>>> GetTbl_Detalle_venta()
        {
            return await _context.tbl_Ventas.ToListAsync();
        }

        // GET api/tbl_Venta/2
        [HttpGet("{idVenta}")]

        public async Task<ActionResult<tbl_Venta>> Gettbl_Venta(int id)
        {
            var tbl_Venta = await _context.tbl_Ventas.FindAsync(id);

            if (tbl_Venta == null)
            {
                return NotFound();
            }

            return tbl_Venta;
        }


        // put api/tbl_Venta/2 
        [HttpPut("idVenta")]
        public async Task<IActionResult> puttbl_Venta(int id, tbl_Venta tbl_Venta)
        {
            if (id != tbl_Venta.idVenta)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_VentaExists(id))
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

        //POst api/tbl_Venta
        [HttpPost]
        public async Task<ActionResult<tbl_Venta>> Posttbl_Venta(tbl_Venta tbl_Venta)
        {
            _context.tbl_Ventas.Add(tbl_Venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Venta", new { id = tbl_Venta.idVenta }, tbl_Venta);
        }

        //Delete Api/tbl_Venta / 2 

        [HttpDelete("idVenta")]
        public async Task<ActionResult<tbl_Venta>> Deletetbl_Venta(int id)
        {
            var tbl_Venta = await _context.tbl_Ventas.FindAsync(id);

            if (tbl_Venta == null)
            {
                return NotFound();
            }

            _context.tbl_Ventas.Remove(tbl_Venta);
            await _context.SaveChangesAsync();

            return tbl_Venta;
        }

        private bool tbl_VentaExists(int id)
        {
            return _context.tbl_Ventas.Any(e => e.idVenta == id);
        }
    }

}




