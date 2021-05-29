using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace umg.Entidades.Almacen
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error por favor validar")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(256)]
        public string descripcion { get; set; }
        [Required]
        [StringLength(50, MinimumLength =3,ErrorMessage ="La descripcion no debe tener un maximo de 50 caracteres, validar por favor")]
        public bool condicion { get; set; }

         }
    }
