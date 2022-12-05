namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoNotificacion")]
    public partial class TipoNotificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoNotificacion()
        {
            UsuarioTipoNotificacion = new HashSet<UsuarioTipoNotificacion>();
        }

        public int TipoNotificacionId { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }

        public string ContenidoPlantilla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioTipoNotificacion> UsuarioTipoNotificacion { get; set; }
    }
}
