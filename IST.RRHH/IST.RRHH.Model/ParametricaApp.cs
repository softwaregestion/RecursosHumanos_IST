namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParametricaApp")]
    public partial class ParametricaApp
    {
        [Key]
        public int ParametricaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Parametro { get; set; }

        [Required]
        [StringLength(500)]
        public string Texto { get; set; }

        [StringLength(500)]
        public string Valor { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public bool? Activo { get; set; }
    }
}
