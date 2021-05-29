using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;
using umg.Entidades.Ventas;

namespace umg.Datos.Mapping.Ventas
{
    class tbl_detalleIngresoMap : IEntityTypeConfiguration<tbl_detalleIngreso>
    {

        public void Configure(EntityTypeBuilder<tbl_detalleIngreso> builder)
        {
            builder.ToTable("tbl_detalleIngreso")
            .HasKey(c => c.idDetalleIngreso);

            builder.Property(c => c.id_ingreso);

            builder.Property(c => c.idArticulo);
               

            builder.Property(c => c.CantidadDetalleIngreso);

            builder.Property(c => c.precioDetalleIngreso)
                .HasMaxLength(11);
        }
    }


}