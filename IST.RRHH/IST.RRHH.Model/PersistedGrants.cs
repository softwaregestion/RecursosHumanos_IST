namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PersistedGrants
    {
        [Key]
        [StringLength(200)]
        public string Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(200)]
        public string SubjectId { get; set; }

        [Required]
        [StringLength(200)]
        public string ClientId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Expiration { get; set; }

        [Required]
        public string Data { get; set; }
    }
}
