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
    public class tbl_Detalle_VentasController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_Detalle_VentasController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Detalle_Ventas/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Detalle_venta>>> GetTbl_Detalle_venta()
        {
            return await _context.tbl_Detalle_ventas.ToListAsync();
        }

        // GET api/tbl_Detalle_Ventas/2
        [HttpGet("{IdDetalleVenta}")]

        public async Task<ActionResult<tbl_Detalle_venta>> Gettbl_Detalle_venta(int id)
        {
            var tbl_Detalle_venta = await _context.tbl_Detalle_ventas.FindAsync(id);

            if (tbl_Detalle_venta == null)
            {
                return NotFound();
            }

            return tbl_Detalle_venta;
        }


        // put api/tbl_Detalle_ventas/2 
        [HttpPut("IdDetalleVenta")]
        public async Task<IActionResult> puttbl_Detalle_venta(int id, tbl_Detalle_venta tbl_Detalle_venta)
        {
            if (id != tbl_Detalle_venta.IdDetalleVenta)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Detalle_venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_Detalle_ventaExists(id))
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

        //POst api/tbl_Detalle_ventas
        [HttpPost]
        public async Task<ActionResult<tbl_Detalle_venta>> Posttbl_Detalle_venta(tbl_Detalle_venta tbl_Detalle_venta)
        {
            _context.tbl_Detalle_ventas.Add(tbl_Detalle_venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Detalle_venta", new { id = tbl_Detalle_venta.IdDetalleVenta }, tbl_Detalle_venta);
        }

        //Delete Api/tbl_Detalle_ventas / 2 

        [HttpDelete("IdDetalleVenta")]
        public async Task<ActionResult<tbl_Detalle_venta>> Deletetbl_Detalle_venta(int id)
        {
            var tbl_Detalle_venta = await _context.tbl_Detalle_ventas.FindAsync(id);

            if (tbl_Detalle_venta == null)
            {
                return NotFound();
            }

            _context.tbl_Detalle_ventas.Remove(tbl_Detalle_venta);
            await _context.SaveChangesAsync();

            return tbl_Detalle_venta;
        }

        private bool tbl_Detalle_ventaExists(int id)
        {
            return _context.tbl_Detalle_ventas.Any(e => e.IdDetalleVenta == id);
        }
    }

}



