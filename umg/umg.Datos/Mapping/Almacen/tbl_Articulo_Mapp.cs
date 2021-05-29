using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Almacen;

namespace umg.Datos.Mapping.Almacen
    {
        
    public class tbl_Articulo_Mapp : IEntityTypeConfiguration<tbl_Articulo_>
        {
            public void Configure(EntityTypeBuilder<tbl_Articulo_> builder)
            {
                builder.ToTable("tbl_Articulo_")
                .HasKey(c => c.IdCodigoArticulo);
                builder.Property(c => c.precioArticulo);
                builder.Property(c => c.stock);
                    
            }
        }
    }

}

