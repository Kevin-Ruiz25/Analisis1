using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Ventas
{
    public class tbl_Detalle_venta_
    {

        public int idDetalleVenta_ { get; set; }
        public int IdDetalleVenta { get; set; }
        public decimal precioVenta { get; set; }
        [Required]

        public decimal DescuentoVenta { get; set; }


    }
}
