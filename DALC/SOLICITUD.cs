//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SOLICITUD
    {
        public SOLICITUD()
        {
            this.RESOLUCION = new HashSet<RESOLUCION>();
        }
    
        public decimal ID_SOLICITUD { get; set; }
        public decimal ID_PERMISO { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECHA_SOLICITUD { get; set; }
    
        public virtual PERMISO PERMISO { get; set; }
        public virtual ICollection<RESOLUCION> RESOLUCION { get; set; }
    }
}
