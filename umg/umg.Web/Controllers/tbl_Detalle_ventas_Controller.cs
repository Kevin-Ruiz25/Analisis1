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
    public class tbl_Detalle_ventas_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_Detalle_ventas_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Detalle_Ventas_/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Detalle_venta>>> GetTbl_Detalle_venta_()
        {
            return await _context.tbl_Detalle_ventas_.ToListAsync();
        }

        // GET api/tbl_Detalle_Ventas_/2
        [HttpGet("{IdDetalleVenta_}")]

        public async Task<ActionResult<tbl_Detalle_venta>> Gettbl_Detalle_ventas_(int id)
        {
            var tbl_Detalle_venta_ = await _context.tbl_Detalle_ventas_.FindAsync(id);

            if (tbl_Detalle_venta_ == null)
            {
                return NotFound();
            }

            return tbl_Detalle_venta_;
        }


        // put api/tbl_Detalle_ventas_/2 
        [HttpPut("IdDetalleVenta_")]
        public async Task<IActionResult> puttbl_Detalle_venta_(int id, tbl_Detalle_venta tbl_Detalle_ventas_)
        {
            if (id != tbl_Detalle_ventas_.IdDetalleVenta_)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Detalle_ventas_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_Detalle_venta_Exists(id))
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

        //POst api/tbl_Detalle_ventas_
        [HttpPost]
        public async Task<ActionResult<tbl_Detalle_venta>> Posttbl_Detalle_ventas_(tbl_Detalle_venta tbl_Detalle_ventas_)
        {
            _context.tbl_Detalle_ventas_.Add(tbl_Detalle_ventas_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Detalle_venta_", new { id = tbl_Detalle_ventas_.IdDetalleVenta_ }, tbl_Detalle_ventas_);
        }

        //Delete Api/tbl_Detalle_ventas / 2 

        [HttpDelete("IdDetalleVenta_")]
        public async Task<ActionResult<tbl_Detalle_venta>> Deletetbl_Detalle_ventas_(int id)
        {
            var tbl_Detalle_venta_ = await _context.tbl_Detalle_ventas_.FindAsync(id);

            if (tbl_Detalle_venta_ == null)
            {
                return NotFound();
            }

            _context.tbl_Detalle_ventas_.Remove(tbl_Detalle_venta_);
            await _context.SaveChangesAsync();

            return tbl_Detalle_venta_;
        }

        private bool tbl_Detalle_venta_Exists(int id)
        {
            return _context.tbl_Detalle_ventas_.Any(e => e.IdDetalleVenta_ == id);
        }
    }

}




