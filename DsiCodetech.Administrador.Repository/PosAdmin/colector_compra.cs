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
    
    public partial class colector_compra
    {
        public System.Guid id_compra { get; set; }
        public Nullable<System.Guid> id_proveedor { get; set; }
        public string no_factura { get; set; }
        public System.DateTime fecha_compra { get; set; }
        public Nullable<System.Guid> id_pedido { get; set; }
        public bool cancelada { get; set; }
        public Nullable<System.DateTime> fecha_cancelacion { get; set; }
        public short no_entrada { get; set; }
        public string observaciones { get; set; }
    }
}