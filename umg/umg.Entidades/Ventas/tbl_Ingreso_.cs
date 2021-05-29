using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Ventas
{
   public class tbl_Ingreso_
    {

        public int idIngreso_ { get; set; }

        public int idIngreso { get; set; }

        public decimal TotalIngreso { get; set; }
        [Required]


        public bool Condicion { get; set; }


    }
}
