using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Ingreso
    {
        public int idIngreso { get; set; }

        public int idProveedor { get; set; }
        public int idUsuario { get; set; }

        public String TipoComprobanteIngreso { get; set; }

        public String serieComprobanteIngreso { get; set; }

        public DateTime FechaHoraIngreso { get; set; }

        public decimal ImpuestoIngreso { get; set; }

    }
}
