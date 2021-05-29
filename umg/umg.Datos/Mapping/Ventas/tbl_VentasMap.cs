using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Ventas;

namespace umg.Datos.Mapping.Ventas
{



    public class tbl_VentaMap : IEntityTypeConfiguration<tbl_Venta>


    {

        public void Configure(EntityTypeBuilder<tbl_Venta> builder)
        {
            builder.ToTable("tbl_Venta")
            .HasKey(Ve => Ve.idVenta);

            builder.Property(Ve => Ve.idUsuario);


            builder.Property(ve => ve.idPersona);



            builder.Property(ve => ve.serieComprobanteVenta)
                .HasMaxLength(7);




            builder.Property(ve => ve.numComprobanteVenta)
                .HasMaxLength(10);


            builder.Property(ve => ve.FechaHora);
        }
    }

}







