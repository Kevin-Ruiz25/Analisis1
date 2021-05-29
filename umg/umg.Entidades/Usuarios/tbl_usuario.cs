using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Usuarios
{
   public class tbl_usuario
    {
        public int idUsuario { get; set; }
      

        public int idRol { get; set; }

        public int idTelefono { get; set; }


        public string nombreUsuario { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "el nombre de usuario no debe de tener mas de 100 caracteres, por favor validar")]

        public int numDocumentoUsuario { get; set; }

        public string emailUsuario { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        


        public byte passwordHash { get; set; }

        public byte passwordSalt { get; set; }

    }


}