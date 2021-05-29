using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;

namespace umg.Datos.Mapping.Usuario
{
    public class tbl_UsuarioMap : IEntityTypeConfiguration<tbl_usuario>
    {
        public void Configure(EntityTypeBuilder<tbl_usuario> builder)
        {
            builder.ToTable("tbl_usuario")
            .HasKey(c => c.idUsuario);

            builder.Property(c => c.idRol);

            builder.Property(c => c.idTelefono)
               .HasMaxLength(70);

            builder.Property(c => c.nombreUsuario)
                .HasMaxLength(100);

            builder.Property(c => c.numDocumentoUsuario)
                .HasMaxLength(20);

            builder.Property(c => c.emailUsuario)
                .HasMaxLength(70);

            builder.Property(c => c.passwordHash)
                .HasMaxLength(1);

            builder.Property(c => c.passwordHash)
                .HasMaxLength(1);








        }
}
