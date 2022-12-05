namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BackAspNetUsers
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(450)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccessFailedCount { get; set; }

        public string ConcurrencyStamp { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool EmailConfirmed { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool LockoutEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        [StringLength(256)]
        public string NormalizedEmail { get; set; }

        [StringLength(256)]
        public string NormalizedUserName { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool PhoneNumberConfirmed { get; set; }

        public string SecurityStamp { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool TwoFactorEnabled { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }
    }
}
