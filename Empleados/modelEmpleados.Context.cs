﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenimientos
{
    using global::Empleados;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class ActivosFijosEntities : DbContext
    {
        public ActivosFijosEntities()
            : base("name=ActivosFijosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivoFijoes> ActivoFijoes { get; set; }
        public virtual DbSet<CalculoDepreciacions> CalculoDepreciacions { get; set; }
        public virtual DbSet<Departamentoes> Departamentoes { get; set; }
        public virtual DbSet<Empleadoes> Empleadoes { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<MetodoDepreciacions> MetodoDepreciacions { get; set; }
        public virtual DbSet<Parametroes> Parametroes { get; set; }
        public virtual DbSet<Proveedors> Proveedors { get; set; }
        public virtual DbSet<TipoActivoes> TipoActivoes { get; set; }
        public virtual DbSet<TipoPagoes> TipoPagoes { get; set; }
        public virtual DbSet<Ubicacions> Ubicacions { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
