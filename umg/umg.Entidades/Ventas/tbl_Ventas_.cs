using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Ventas_
    {
        public int IdVenta_ { get; set; }

        public String tipoComprobanteVenta { get; set; }

        public decimal Impuesto { get; set; }

        public decimal total { get; set; }

        public bool CondicionVenta { get; set; }
    }
}
