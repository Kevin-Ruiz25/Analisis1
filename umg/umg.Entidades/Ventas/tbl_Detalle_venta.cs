using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Detalle_venta
    {

        public int IdDetalleVenta { get; set; }

        public int idArticulo { get; set; } //forenea

        public int idVenta { get; set; } // forenea

        public String CantidadVentas { get; set; }

    }
}
