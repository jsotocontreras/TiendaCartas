//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaCartas_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.compra = new HashSet<compra>();
        }
    
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string clave { get; set; }
        public string correo { get; set; }
        public Nullable<int> edad { get; set; }
        public string tipo_usuario { get; set; }
        public string foto_usuario { get; set; }
        public bool recordar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra> compra { get; set; }
    }
}
