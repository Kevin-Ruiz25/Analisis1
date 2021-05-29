using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Venta
    {

        public int idVenta { get; set; }

        public int idUsuario { get; set; }

        public int idPersona { get; set; }

        public String serieComprobanteVenta { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 3, ErrorMessage = "la serie de comprobante no debe de tener mas de 7 caracteres, por favor validar")]


        public string numComprobanteVenta { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "el numero comprobante de venta no debe de tener mas de 10 caracteres, por favor validar")]

        public DateTime FechaHora { get; set; }

    }
}
