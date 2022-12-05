namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        public int Id { get; set; }

        public bool Enabled { get; set; }

        [Required]
        [StringLength(200)]
        public string ClientId { get; set; }

        [Required]
        [StringLength(200)]
        public string ProtocolType { get; set; }

        public bool RequireClientSecret { get; set; }

        [StringLength(200)]
        public string ClientName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(2000)]
        public string ClientUri { get; set; }

        [StringLength(2000)]
        public string LogoUri { get; set; }

        public bool RequireConsent { get; set; }

        public bool AllowRememberConsent { get; set; }

        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }

        public bool RequirePkce { get; set; }

        public bool AllowPlainTextPkce { get; set; }

        public bool AllowAccessTokensViaBrowser { get; set; }

        [StringLength(2000)]
        public string FrontChannelLogoutUri { get; set; }

        public bool FrontChannelLogoutSessionRequired { get; set; }

        [StringLength(2000)]
        public string BackChannelLogoutUri { get; set; }

        public bool BackChannelLogoutSessionRequired { get; set; }

        public bool AllowOfflineAccess { get; set; }

        public int IdentityTokenLifetime { get; set; }

        public int AccessTokenLifetime { get; set; }

        public int AuthorizationCodeLifetime { get; set; }

        public int? ConsentLifetime { get; set; }

        public int AbsoluteRefreshTokenLifetime { get; set; }

        public int SlidingRefreshTokenLifetime { get; set; }

        public int RefreshTokenUsage { get; set; }

        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }

        public int RefreshTokenExpiration { get; set; }

        public int AccessTokenType { get; set; }

        public bool EnableLocalLogin { get; set; }

        public bool IncludeJwtId { get; set; }

        public bool AlwaysSendClientClaims { get; set; }

        [StringLength(200)]
        public string ClientClaimsPrefix { get; set; }

        [StringLength(200)]
        public string PairWiseSubjectSalt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Updated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastAccessed { get; set; }

        public int? UserSsoLifetime { get; set; }

        [StringLength(100)]
        public string UserCodeType { get; set; }

        public int DeviceCodeLifetime { get; set; }

        public bool NonEditable { get; set; }
    }
}
