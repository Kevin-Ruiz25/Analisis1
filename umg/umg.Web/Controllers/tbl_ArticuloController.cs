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
    public class tbl_ArticuloController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public tbl_ArticuloController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/tbl_articulo/1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_articulo>>> Gettbl_articulos()
        {
            return await _context.tbl_Articulos.ToListAsync();
        }

        // GET api/tbl_articulo/2
        [HttpGet("{IdArticulo}")]

        public async Task<ActionResult<tbl_articulo>> Gettbl_articulos(int id)
        {
            var tbl_articulo = await _context.tbl_Articulos.FindAsync(id);

            if (tbl_articulo == null)
            {
                return NotFound();
            }

            return tbl_articulo;
        }


        // put api/tbl_articulo/2 
        [HttpPut("IdArticulo")]
        public async Task<IActionResult> puttbl_articulo(int id, tbl_articulo tbl_articulo)
        {
            if (id != tbl_articulo.IdArticulo)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(tbl_articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!tbl_articuloExists(id))
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

        //POst api/tbl_Articulos
        [HttpPost]
        public async Task<ActionResult<tbl_articulo>> Posttbl_articulo(tbl_articulo tbl_articulo)
        {
            _context.tbl_Articulos.Add(tbl_articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettbl_articulo", new { id = tbl_articulo.IdArticulo }, tbl_articulo);
        }

        //Delete Api/Articulo/ 2 

        [HttpDelete("IdArticulo")]
        public async Task<ActionResult<tbl_articulo>> Deletetbl_articulo(int id)
        {
            var tbl_articulo = await _context.tbl_Articulos.FindAsync(id);

            if (tbl_articulo == null)
            {
                return NotFound();
            }

            _context.tbl_Articulos.Remove(tbl_articulo);
            await _context.SaveChangesAsync();

            return tbl_articulo;
        }

        private bool tbl_articuloExists(int id)
        {
            return _context.tbl_Articulos.Any(e => e.IdArticulo == id);
        }
    }

}


    


