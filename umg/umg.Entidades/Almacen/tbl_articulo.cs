using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Almacen
{
     public class tbl_articulo
    {
        public int IdArticulo { get; set; }

        public int IdCodigoArticulo { get; set; } // llave foranea

        public int IdCategoria { get; set; } // llave foranea

        public String nombreArticulo { get; set; }

        public String DescripcionArticulo { get; set; }

        public bool condicionArticulo { get; set; }

    }
}
