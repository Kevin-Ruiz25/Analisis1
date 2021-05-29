using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Ventas;

namespace umg.Datos.Mapping.Ventas
{
    class tbl_Ventas_Map : IEntityTypeConfiguration<tbl_Venta_>
    {
        public void Configure(EntityTypeBuilder<tbl_Venta_> builder)
        {
            builder.ToTable("tbl_usuario_")
            .HasKey(Ve => Ve.IdVenta_);

            builder.Property(Ve => Ve.idVenta)
             .HasMaxLength(50);

            builder.Property(ve => ve.tipoComprobanteVenta)
             .HasMaxLength(50);


            builder.Property(ve => ve.Impuesto);




            builder.Property(ve => ve.total);


            builder.Property(ve => ve.CondicionVenta);



        }
    }

}