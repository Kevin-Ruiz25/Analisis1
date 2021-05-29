using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Almacen
{
     public class tbl_articulo
    {
        public int IdArticulo { get; set; }

        public int IdCodigoArticulo { get; set; } // llave foranea

        public int IdCategoria { get; set; } // llave foranea

        public String nombreArticulo { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el articulo no debe de tener mas de 50 caracteres, por favor validar")]


        public String DescripcionArticulo { get; set; }
        [Required]
        [StringLength(256, MinimumLength = 3, ErrorMessage = "la descripcion no debe de tener mas de 256 caracteres, por favor validar")]

        public bool condicionArticulo { get; set; }

    }
}
