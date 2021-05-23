using System;
using System.Collections.Generic;
using System.Text;

namespace umg.Entidades.Usuarios
{
   public class tbl_Telefono
    {
        public int idTelefono { get; set; }

        public int idPersona { get; set; }

        public String telefonoPersonal { get; set; }

        public String telefonoResidencia { get; set; }

        public String TelefonoLaboral { get; set; }

    }


}