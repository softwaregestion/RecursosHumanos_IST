namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiScopeClaims
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Type { get; set; }

        public int ApiScopeId { get; set; }
    }
}
