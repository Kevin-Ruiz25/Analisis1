using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Detalle_venta
    {

        public int IdDetalleVenta { get; set; }

        public int idArticulo { get; set; } //forenea

        public int idVenta { get; set; } // forenea

        public String CantidadVenta{ get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "la cantidad de ventas no debe de tener mas de 10 caracteres, por favor validar")]

    }
}
