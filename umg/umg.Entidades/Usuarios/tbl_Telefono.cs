using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Usuarios
{
    public class tbl_Telefono
    {
        public int idTelefono { get; set; }

        public int idPersona { get; set; }

        public String telefonoPersonal { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "el telefono personal no debe de tener mas de 8 caracteres, por favor validar")]


        public String telefonoResidencia { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "el telefono de casa no debe de tener mas de 8 caracteres, por favor validar")]
        public String TelefonoLaboral { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "el telefono laboral no debe de tener mas de 8 caracteres, por favor validar")]


    }


}