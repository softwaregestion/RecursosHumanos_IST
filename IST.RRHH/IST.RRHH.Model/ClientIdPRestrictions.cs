namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientIdPRestrictions
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Provider { get; set; }

        public int ClientId { get; set; }
    }
}
