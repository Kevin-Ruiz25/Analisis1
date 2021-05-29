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
    public class tbl_Ventas_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_Ventas_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Ventas_/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Venta_>>> GetTbl_Venta_()
        {
            return await _context.tbl_Ventas_.ToListAsync();
        }

        // GET api/tbl_Venta_/2
        [HttpGet("{IdVenta}")]

        public async Task<ActionResult<tbl_Venta_>> Gettbl_Venta_(int id)
        {
            var tbl_Venta_ = await _context.tbl_Ventas_.FindAsync(id);

            if (tbl_Venta_ == null)
            {
                return NotFound();
            }

            return tbl_Venta_;
        }


        // put api/tbl_Venta_/2 
        [HttpPut("IdVentas")]
        public async Task<IActionResult> puttbl_Venta_(int id, tbl_Venta_ tbl_Venta_)
        {
            if (id != tbl_Venta_.idVenta)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Venta_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_Venta_Exists(id))
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

        //POst api/tbl_Venta_
        [HttpPost]
        public async Task<ActionResult<tbl_Venta_>> Posttbl_Venta_(tbl_Venta_ tbl_Venta_)
        {
            _context.tbl_Ventas_.Add(tbl_Venta_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Venta_", new { id = tbl_Venta_.idVenta }, tbl_Venta_);
        }

        //Delete Api/tbl_Venta_ / 2 

        [HttpDelete("IdVenta")]
        public async Task<ActionResult<tbl_Venta_>> Deletetbl_Venta_(int id)
        {
            var tbl_Venta_ = await _context.tbl_Ventas_.FindAsync(id);

            if (tbl_Venta_ == null)
            {
                return NotFound();
            }

            _context.tbl_Ventas_.Remove(tbl_Venta_);
            await _context.SaveChangesAsync();

            return tbl_Venta_;
        }

        private bool tbl_Venta_Exists(int id)
        {
            return _context.tbl_Ventas_.Any(e => e.idVenta == id);
        }
    }

}



