//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsiCodetech.Administrador.Repository.PosAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventario_captura
    {
        public System.Guid id_captura { get; set; }
        public System.Guid id_inventario_fisico { get; set; }
        public long num_captura { get; set; }
        public string cod_barras { get; set; }
        public System.DateTime fecha_captura { get; set; }
        public decimal cant_cja { get; set; }
        public decimal cant_pza { get; set; }
        public bool upload { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual inventario_fisico inventario_fisico { get; set; }
    }
}