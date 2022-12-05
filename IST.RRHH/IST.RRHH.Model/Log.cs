namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogId { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string UsuarioId { get; set; }
    }
}
