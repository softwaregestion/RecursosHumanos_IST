namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargo")]
    public partial class Cargo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CargoID { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }
    }
}
