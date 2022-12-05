namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeviceCodes
    {
        [Key]
        [StringLength(200)]
        public string UserCode { get; set; }

        [Required]
        [StringLength(200)]
        public string DeviceCode { get; set; }

        [StringLength(200)]
        public string SubjectId { get; set; }

        [Required]
        [StringLength(200)]
        public string ClientId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Expiration { get; set; }

        [Required]
        public string Data { get; set; }
    }
}
