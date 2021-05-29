using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Almacen
{
     public class tbl_Articulo_
    {
        public int IdCodigoArticulo { get; set; }
        [Required]

        public float precioArticulo { get; set; }
        [Required]

        public int stock { get; set; }

    }

}