namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientGrantTypes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string GrantType { get; set; }

        public int ClientId { get; set; }
    }
}
