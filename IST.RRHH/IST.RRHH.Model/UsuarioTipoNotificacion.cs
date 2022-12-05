namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioTipoNotificacion")]
    public partial class UsuarioTipoNotificacion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoNotificacionId { get; set; }

        public DateTime UltimaModificacion { get; set; }

        [StringLength(250)]
        public string UsuarioModificacion { get; set; }

        public virtual TipoNotificacion TipoNotificacion { get; set; }
    }
}
