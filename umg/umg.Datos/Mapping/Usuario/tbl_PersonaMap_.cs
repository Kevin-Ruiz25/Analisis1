using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;

namespace umg.Datos.Mapping.Usuario
{
    
    
        public class Tbl_personaMap_ : IEntityTypeConfiguration<tbl_Persona_>
        {
            public void Configure(EntityTypeBuilder<tbl_Persona_> builder)
            {
                builder.ToTable("tbl_persona")
                    .HasKey(c => c.idPersona_);

                builder.Property(c => c.idPersona);

                builder.Property(c => c.tipoPersona)
                    .HasMaxLength(50);

                builder.Property(ar => ar.tipoDocumento)
                    .HasMaxLength(3);

                builder.Property(c => c.Direccion)
                    .HasMaxLength(50);

            }


        }
    
}
