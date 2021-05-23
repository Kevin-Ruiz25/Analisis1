using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using umg.Datos.Mapping.Almacen;
using umg.Entidades.Almacen;

namespace umg.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbContextSistema(DbContextOptions<DbContextSistema> Options) : base(Options) { 
        

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
             modelBuilder.ApplyConfiguration(new CategoriaMap());
             modelBuilder.ApplyConfiguration(new CategoriaMap());
             modelBuilder.ApplyConfiguration(new CategoriaMap());
             modelBuilder.ApplyConfiguration(new CategoriaMap());
             modelBuilder.ApplyConfiguration(new CategoriaMap());

        }

    }

}

        