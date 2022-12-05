namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientRedirectUris
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2000)]
        public string RedirectUri { get; set; }

        public int ClientId { get; set; }
    }
}
