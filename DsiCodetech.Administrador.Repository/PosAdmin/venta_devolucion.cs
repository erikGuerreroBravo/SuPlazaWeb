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
    
    public partial class venta_devolucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venta_devolucion()
        {
            this.venta_devolucion_articulo = new HashSet<venta_devolucion_articulo>();
        }
    
        public System.Guid id_devolucion { get; set; }
        public long folio { get; set; }
        public int id_pos { get; set; }
        public System.Guid id_venta { get; set; }
        public System.DateTime fecha_dev { get; set; }
        public string vendedor { get; set; }
        public string supervisor { get; set; }
        public decimal cant_dev { get; set; }
        public bool upload { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
        public virtual venta venta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_devolucion_articulo> venta_devolucion_articulo { get; set; }
    }
}
