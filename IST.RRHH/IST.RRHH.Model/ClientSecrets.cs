namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientSecrets
    {
        public int Id { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        [StringLength(4000)]
        public string Value { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Expiration { get; set; }

        [Required]
        [StringLength(250)]
        public string Type { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        public int ClientId { get; set; }
    }
}
