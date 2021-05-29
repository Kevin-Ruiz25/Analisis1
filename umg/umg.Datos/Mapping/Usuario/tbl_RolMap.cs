using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;

namespace umg.Datos.Mapping.Usuario
{
        public class Tbl_RolMap : IEntityTypeConfiguration<tbl_Rol>
       
        {
            public void Configure(EntityTypeBuilder<tbl_Rol> builder)
            {
                builder.ToTable("tbl_Rol")
                    .HasKey(c => c.IdRol);
                builder.Property(c => c.nombreRol)
               .HasMaxLength(50);

                builder.Property(c => c.descripcionRol)
                    .HasMaxLength(100);

                builder.Property(ar => ar.condicion);




            }

        }

    }


}