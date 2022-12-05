namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnvioLog")]
    public partial class EnvioLog
    {
        public Guid EnvioLogId { get; set; }

        public string Mensaje { get; set; }

        [StringLength(50)]
        public string UsuarioId { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
