using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Almacen;
using umg.Entidades.Usuarios;

namespace umg.Datos.Mapping.Usuario
{
        public class Tbl_TelefonoMap : IEntityTypeConfiguration<tbl_Telefono>
        {
            public void Configure(EntityTypeBuilder<tbl_Telefono> builder)
            {
                builder.ToTable("tbl_Telefono")
                 .HasKey(c => c.idTelefono);

                builder.Property(c => c.idPersona);

                builder.Property(c => c.telefonoPersonal)
                 .HasMaxLength(8);

                builder.Property(c => c.telefonoResidencia)
                 .HasMaxLength(8);

            builder.Property(c => c.TelefonoLaboral)
                 .HasMaxLength(8);

            }
        }
    }