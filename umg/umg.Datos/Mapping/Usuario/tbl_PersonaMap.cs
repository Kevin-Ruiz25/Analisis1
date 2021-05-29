using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;

namespace umg.Datos.Mapping.Usuario
{
        public class tbl_personaMap : IEntityTypeConfiguration<tbl_Persona>
        {
            public void Configure(EntityTypeBuilder<tbl_Persona> builder)
            {
                builder.ToTable("tbl_Persona")
                    .HasKey(c => c.idPersona);
                builder.Property(c => c.idTelefono);

                builder.Property(c => c.nombrePersona)
                    .HasMaxLength(50);

                builder.Property(ar => ar.numeroDeDocumento);

                builder.Property(c => c.EmailPersona)
                    .HasMaxLength(50);

            }
        }

    }