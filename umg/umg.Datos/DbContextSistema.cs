using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Datos.Mapping.Almacen;
using umg.Datos.Mapping.Usuario;
using umg.Datos.Mapping.Ventas;
using umg.Entidades.Almacen;
using umg.Entidades.Usuarios;
using umg.Entidades.Ventas;

namespace umg.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet <tbl_articulo> tbl_Articulos { get; set; }

        public DbSet<tbl_Articulo_> tbl_Articulos_ { get; set; }

        public DbSet<tbl_Persona> tbl_Personas { get; set; }

        public DbSet<tbl_Persona_> tbl_Personas_ { get; set; }

        public DbSet<tbl_Rol> tbl_Rols { get; set; }

        public DbSet<tbl_Telefono> tbl_Telefonos { get; set; }

        public DbSet<tbl_usuario> tbl_usuarios { get; set; }

        public DbSet<tbl_usuario_> tbl_usuarios_ { get; set; }

        public DbSet<tbl_Detalle_venta> tbl_Detalle_ventas { get; set; }

        public DbSet<tbl_Detalle_venta_> tbl_Detalle_ventas_ { get; set; }

        public DbSet<tbl_detalleIngreso> tbl_DetalleIngresos { get; set; }

        public DbSet<tbl_Ingreso> tbl_Ingresos { get; set; }
        public DbSet<tbl_Venta> tbl_Ventas { get; set; }
        public DbSet<tbl_Venta_> tbl_Ventas_ { get; set; }



        public DbContextSistema(DbContextOptions<DbContextSistema> Options) : base(Options) { 
        

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
             modelBuilder.ApplyConfiguration(new CategoriaMap());
             modelBuilder.ApplyConfiguration(new tbl_articuloMap());
             modelBuilder.ApplyConfiguration(new tbl_Articulo_Mapp ());
             modelBuilder.ApplyConfiguration(new tbl_personaMap());
             modelBuilder.ApplyConfiguration(new Tbl_personaMap_());
             modelBuilder.ApplyConfiguration(new Tbl_RolMap());
             modelBuilder.ApplyConfiguration(new Tbl_TelefonoMap());
             modelBuilder.ApplyConfiguration(new tbl_UsuarioMap());
             modelBuilder.ApplyConfiguration(new tbl_Usuario_Map());
             modelBuilder.ApplyConfiguration(new tbl_Detalle_ventaMap());
             modelBuilder.ApplyConfiguration(new tbl_Detalle_venta_Map());
             modelBuilder.ApplyConfiguration(new tbl_detalleIngresoMap());
             modelBuilder.ApplyConfiguration(new tbl_IngresoMap());
             modelBuilder.ApplyConfiguration(new tbl_IngresoMap());
             modelBuilder.ApplyConfiguration(new tbl_VentaMap());
             modelBuilder.ApplyConfiguration(new tbl_Ventas_Map());


        }
    }

           

    }

}

        