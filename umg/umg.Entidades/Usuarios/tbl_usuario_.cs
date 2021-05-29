using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Usuarios
{
   public class tbl_usuario_
    {
        public int idUsuario_ { get; set; }

        public int idUsuario { get; set; }
        public String direccionUsuario { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "la direccion del usuario no debe de tener mas de 70 caracteres, por favor validar")]

        public bool condicion { get; set; }
        [Required]



    }
}
