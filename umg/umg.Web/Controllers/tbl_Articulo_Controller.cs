using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umg.Datos;
using umg.Entidades.Almacen;

namespace umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tbl_Articulo_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public tbl_Articulo_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_Articulo_/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Articulo_>>> Gettbl_Articulos_()
        {
            return await _context.tbl_Articulos_.ToListAsync();
        }

        // GET api/tbl_Articulo_/2
        [HttpGet("{IdCodigoArticulo}")]

        public async Task<ActionResult<tbl_Articulo_>> Gettbl_Articulos_(int id)
        {
            var tbl_Articulo_ = await _context.tbl_Articulos_.FindAsync(id);

            if (tbl_Articulo_ == null)
            {
                return NotFound();
            }

            return tbl_Articulo_;
        }


        // put api/tbl_Articulo_/2 
        [HttpPut("IdCodigoArticulo")]
        public async Task<IActionResult> puttbl_Articulo_(int id, tbl_Articulo_ tbl_Articulo_)
        {
            if (id != tbl_Articulo_.IdCodigoArticulo)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_Articulo_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_Articulo_Exists(id))
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

        //POst api/tbl_Articulo_
        [HttpPost]
        public async Task<ActionResult<tbl_Articulo_>> Posttbl_Articulo_(tbl_Articulo_ tbl_Articulo_)
        {
            _context.tbl_Articulos_.Add(tbl_Articulo_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_Articulo_", new { id = tbl_Articulo_.IdCodigoArticulo }, tbl_Articulo_);
        }

        //Delete Api/tbl_Articulo_ 2 

        [HttpDelete("IdCodigoArticulo")]
        public async Task<ActionResult<tbl_Articulo_>> Deletetbl_Articulos_(int id)
        {
            var tbl_Articulo_ = await _context.tbl_Articulos_.FindAsync(id);

            if (tbl_Articulo_ == null)
            {
                return NotFound();
            }

            _context.tbl_Articulos_.Remove(tbl_Articulo_);
            await _context.SaveChangesAsync();

            return tbl_Articulo_;
        }

        private bool tbl_Articulo_Exists(int id)
        {
            return _context.tbl_Articulos_.Any(e => e.IdCodigoArticulo == id);
        }
    }

}


