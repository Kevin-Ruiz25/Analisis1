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
    public class CategoriasController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public CategoriasController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        // GET api/Categorias/2
        [HttpGet("{idcategoria}")]

        public async Task<ActionResult<Categoria>> GetCategoria(int id)
        {
            var Categoria = await _context.Categorias.FindAsync(id);
           
            if (Categoria == null)
            {
                return NotFound();
            }

            return Categoria;
        }


        // put api/Categoria/2 
        [HttpPut("idcategoria")]
        public async Task<IActionResult> putCategoria(int id, Categoria categoria)
        {
            if (id != Categoria.idcategoria)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!CategoriaExists(id))
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

        //POst api/Categorias
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getCategoria", new { id = Categoria.idcategoria }, categoria);
        }

        //Delete Api/Categoria 2 

        [HttpDelete("idCategoria")]
        public async Task<ActionResult<Categoria>> DeleteCategoria(int id)
        {
            var Categoria = await _context.Categorias.FindAsync(id);

            if(Categoria == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(Categoria);
            await _context.SaveChangesAsync();

            return Categoria;
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categorias.Any(e => e.idCategoria == id);
        }
    }

}


