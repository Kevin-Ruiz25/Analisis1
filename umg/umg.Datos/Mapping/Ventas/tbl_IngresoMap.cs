using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Entidades.Usuarios;
using umg.Entidades.Ventas;

namespace umg.Datos.Mapping.Ventas
{
    class tbl_IngresoMap : IEntityTypeConfiguration<tbl_Ingreso>
        {
            public void Configure(EntityTypeBuilder<tbl_Ingreso> builder)
            {
                builder.ToTable("tbl_usuario_")
                .HasKey(I => I.idIngreso);

                builder.Property(I => I.idProveedor);

                builder.Property(I => I.idUsuario);
                  

                builder.Property(I => I.TipoComprobanteIngreso)
                   .HasMaxLength(20);


                builder.Property(I => I.serieComprobanteIngreso)
                    .HasMaxLength(50);

                builder.Property(I => I.FechaHoraIngreso);


                builder.Property(I => I.ImpuestoIngreso);

        } 
}
