using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;
using umg.Entidades.Ventas;

namespace umg.Datos.Mapping.Ventas
{
    public class tbl_Detalle_ventaMap : IEntityTypeConfiguration<tbl_Detalle_venta>
    {
        public void Configure(EntityTypeBuilder<tbl_Detalle_venta> builder)
        {
            builder.ToTable("tbl_Detalle_venta")
            .HasKey(c => c.IdDetalleVenta);
                

            builder.Property(c => c.idArticulo);

            builder.Property(c => c.idVenta);
               

            builder.Property(c => c.CantidadVentas)
               .HasMaxLength(10);
        }
    }

}
