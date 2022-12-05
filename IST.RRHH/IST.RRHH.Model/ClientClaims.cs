namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientClaims
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Type { get; set; }

        [Required]
        [StringLength(250)]
        public string Value { get; set; }

        public int ClientId { get; set; }
    }
}
