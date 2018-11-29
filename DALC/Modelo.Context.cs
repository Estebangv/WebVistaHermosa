﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Entidades : DbContext
    {
        public Entidades()
            : base("name=Entidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<MOTIVO> MOTIVO { get; set; }
        public DbSet<PERMISO> PERMISO { get; set; }
        public DbSet<RESOLUCION> RESOLUCION { get; set; }
        public DbSet<SOLICITUD> SOLICITUD { get; set; }
        public DbSet<TIPO_PERMISO> TIPO_PERMISO { get; set; }
        public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public DbSet<UNIDAD> UNIDAD { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int PKG_MODIFICAR_ESTADO(Nullable<decimal> a_IDPER, Nullable<decimal> a_IDSOL, string a_ESTADO)
        {
            var a_IDPERParameter = a_IDPER.HasValue ?
                new ObjectParameter("A_IDPER", a_IDPER) :
                new ObjectParameter("A_IDPER", typeof(decimal));
    
            var a_IDSOLParameter = a_IDSOL.HasValue ?
                new ObjectParameter("A_IDSOL", a_IDSOL) :
                new ObjectParameter("A_IDSOL", typeof(decimal));
    
            var a_ESTADOParameter = a_ESTADO != null ?
                new ObjectParameter("A_ESTADO", a_ESTADO) :
                new ObjectParameter("A_ESTADO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PKG_MODIFICAR_ESTADO", a_IDPERParameter, a_IDSOLParameter, a_ESTADOParameter);
        }
    }
}
