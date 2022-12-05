namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiResources
    {
        public int Id { get; set; }

        public bool Enabled { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string DisplayName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastAccessed { get; set; }

        public bool NonEditable { get; set; }
    }
}
