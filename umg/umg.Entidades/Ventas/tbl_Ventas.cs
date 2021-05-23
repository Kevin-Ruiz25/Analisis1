using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Ventas
    {

        public int idVenta { get; set; }

        public int idUsuario { get; set; }

        public int idPersona { get; set; }

        public String serieComprobanteVenta { get; set; }

        public string numComprobanteVenta { get; set; }

        public DateTime FechaHora { get; set; }

    }
}
