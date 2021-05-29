using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Almacen;

namespace umg.Datos.Mapping.Almacen
{
    public class tbl_articuloMap : IEntityTypeConfiguration<tbl_articulo>
    {
        public void Configure(EntityTypeBuilder<tbl_articulo> builder)
        {
            builder.ToTable("tbl_articulo")
                
                .HasKey(ar => ar.IdArticulo);
            builder.Property(ar => ar.IdCodigoArticulo);


            builder.Property(ar => ar.IdCategoria);
                

            builder.Property(ar => ar.nombreArticulo)
                .HasMaxLength(50);

            builder.Property(ar => ar.DescripcionArticulo)
                .HasMaxLength(250);

            builder.Property(ar => ar.condicionArticulo);



        }
    }
}