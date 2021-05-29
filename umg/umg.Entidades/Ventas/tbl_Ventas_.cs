using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Venta_
    {
        public int IdVenta_ { get; set; }

        public int idVenta { get; set; }

        public String tipoComprobanteVenta { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el tipo comprobante venta no debe de tener mas de 50 caracteres, por favor validar")]


        public decimal Impuesto { get; set; }

        public decimal total { get; set; }

        public bool CondicionVenta { get; set; }
    }
}
