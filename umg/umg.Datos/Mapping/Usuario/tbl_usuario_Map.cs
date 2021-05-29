using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;

namespace umg.Datos.Mapping.Usuario

{
    public class tbl_Usuario_Map : IEntityTypeConfiguration<tbl_usuario_>
    {
        public void Configure(EntityTypeBuilder<tbl_usuario_> builder)
        {
            builder.ToTable("tbl_usuario_")
            .HasKey(c => c.idUsuario_);

            builder.Property(c => c.idUsuario);

            builder.Property(c => c.direccionUsuario)
               .HasMaxLength(70);

             builder.Property(c => c.condicion);

        }
    }
}