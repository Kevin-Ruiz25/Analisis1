using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace umg.Entidades.Usuarios
{ 
    public class tbl_Persona
    {
        
       
        public int idPersona { get; set; }

        public int idTelefono { get; set; }

        public String nombrePersona { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el apartado persona no debe de tener mas de 50 caracteres, por favor validar")]

        public int numeroDeDocumento { get; set; }
        [Required]

        public String EmailPersona { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)];


    }

}







