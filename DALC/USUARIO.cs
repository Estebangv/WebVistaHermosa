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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.PERMISO = new HashSet<PERMISO>();
        }
    
        public string RUT { get; set; }
        public string PASS { get; set; }
        public string NOMBRE { get; set; }
        public string A_PATERNO { get; set; }
        public string A_MATERNO { get; set; }
        public System.DateTime FECHA_INGRESO { get; set; }
        public string MAIL { get; set; }
        public string FONO { get; set; }
        public decimal HABILITADO { get; set; }
        public string NACIONALIDAD { get; set; }
        public decimal ID_TIPOUSUARIO { get; set; }
        public decimal ID_UNIDAD { get; set; }
        public decimal DIAS { get; set; }
    
        public virtual ICollection<PERMISO> PERMISO { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
        public virtual UNIDAD UNIDAD { get; set; }
    }
}