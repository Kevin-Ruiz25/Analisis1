using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;
using umg.Entidades.Ventas;

namespace umg.Datos.Mapping.Ventas
{
    public class tbl_Detalle_venta_Map : IEntityTypeConfiguration<tbl_Detalle_ventas_>
    {
        public void Configure(EntityTypeBuilder<tbl_Detalle_ventas_> builder)
        {
            builder.ToTable("tbl_Detalle_venta")
            .HasKey(c => c.idDetalleVenta_);

            builder.Property(c => c.idDetalleVenta);

            builder.Property(c => c.precioVenta)
               .HasMaxLength(11);

            builder.Property(c => c.DescuentoVenta)
               .HasMaxLength(11);

        }

    }
}