using System.Data.Entity;
using System.Threading.Tasks;

namespace IST.RRHH.Model
{
    public interface IBDContext
    {
        // Agregar entidades aquí

        DbSet<ApiClaims> ApiClaims { get; set; }
        DbSet<ApiProperties> ApiProperties { get; set; }
        DbSet<ApiResources> ApiResources { get; set; }
        DbSet<ApiScopeClaims> ApiScopeClaims { get; set; }
        DbSet<ApiScopes> ApiScopes { get; set; }
        DbSet<ApiSecrets> ApiSecrets { get; set; }
        DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        DbSet<AspNetRoles> AspNetRoles { get; set; }
        DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        DbSet<AspNetUsers> AspNetUsers { get; set; }
        DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        DbSet<ClientClaims> ClientClaims { get; set; }
        DbSet<ClientCorsOrigins> ClientCorsOrigins { get; set; }
        DbSet<ClientGrantTypes> ClientGrantTypes { get; set; }
        DbSet<ClientIdPRestrictions> ClientIdPRestrictions { get; set; }
        DbSet<ClientPostLogoutRedirectUris> ClientPostLogoutRedirectUris { get; set; }
        DbSet<ClientProperties> ClientProperties { get; set; }
        DbSet<ClientRedirectUris> ClientRedirectUris { get; set; }
        DbSet<Clients> Clients { get; set; }
        DbSet<ClientScopes> ClientScopes { get; set; }
        DbSet<ClientSecrets> ClientSecrets { get; set; }
        DbSet<DeviceCodes> DeviceCodes { get; set; }
        DbSet<IdentityClaims> IdentityClaims { get; set; }
        DbSet<IdentityProperties> IdentityProperties { get; set; }
        DbSet<IdentityResources> IdentityResources { get; set; }
        DbSet<PersistedGrants> PersistedGrants { get; set; }
        DbSet<BackAspNetUsers> BackAspNetUsers { get; set; }
        DbSet<TipoNotificacion> TipoNotificacion { get; set; }
        DbSet<UsuarioTipoNotificacion> UsuarioTipoNotificacion { get; set; }
        DbSet<ParametricaApp> ParametricaApp { get; set; }
        DbSet<EnvioEmail> EnvioEmail { get; set; }
        DbSet<Log> Log { get; set; }
        DbSet<Cargo> Cargo { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync();

        Database Database { get; }
    }
}
