using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Usuarios
{
   public class tbl_usuario
    {
        public int idUsuario { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 10)]

        public int idRol { get; set; }

        public int idTelefono { get; set; }

        public string nombreUsuario { get; set; }

        public int numDocumentoUsuario { get; set; }

        public string emailUsuario { get; set; }

        [DataType(DataType.EmailAddress)]

        public string passwordHash { get; set; }

        public string passwordSalt { get; set; }

    }


}