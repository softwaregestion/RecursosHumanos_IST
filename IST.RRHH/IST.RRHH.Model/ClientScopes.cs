namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientScopes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Scope { get; set; }

        public int ClientId { get; set; }
    }
}
