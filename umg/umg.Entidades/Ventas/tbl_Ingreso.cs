using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Ingreso
    {
        public int idIngreso { get; set; }

        public int idProveedor { get; set; }
        public int idUsuario { get; set; }

        public String TipoComprobanteIngreso { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el tipo comprobante ingreso no debe de tener mas de 50 caracteres, por favor validar")]

        public String serieComprobanteIngreso { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "la serie comprobante de ingreso no debe de tener mas de 50 caracteres, por favor validar")]

        public DateTime FechaHoraIngreso { get; set; }
        [Required]

        public decimal ImpuestoIngreso { get; set; }

    }
}
