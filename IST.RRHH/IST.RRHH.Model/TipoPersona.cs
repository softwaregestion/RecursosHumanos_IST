namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoPersona")]
    public partial class TipoPersona
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoPersonaId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
