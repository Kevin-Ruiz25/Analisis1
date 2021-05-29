using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Usuarios
{
    public class tbl_Persona_
    {
        public int idPersona_ { get; set; }

        public int idPersona { get; set; }

        public String tipoPersona { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el tipo de persona no debe de tener mas de 50 caracteres, favor de Validar ")]

        public String tipoDocumento { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "el tipo de documento no debe de tener mas de 3 caracteres, favor de validar")]

        public String Direccion { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "la direccion no debe de tener mas de 50 caracteres,  favor de  validar")]


    


    }
}
