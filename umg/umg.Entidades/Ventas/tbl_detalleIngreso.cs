using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_detalleIngreso
    {

        public int idDetalleIngreso { get; set; }

        public int id_ingreso { get; set; } 

        //Llave Foranea
        public int idArticulo { get; set; }

        //Llave Foranea
        public int CantidadDetalleIngreso { get; set; }

        public decimal precioDetalleIngreso { get; set; }

    }
}
