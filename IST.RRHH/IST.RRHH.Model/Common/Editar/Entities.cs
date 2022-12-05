namespace IST.RRHH.Model.DataBase
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public partial class Entities : DbContext
    {
        public Entities(string connString) : base(connString)
        {

        }
        public Entities()
            : base("name=Entities")
        {
        }

        public virtual DbSet<ApiClaims> ApiClaims { get; set; }
        public virtual DbSet<ApiProperties> ApiProperties { get; set; }
        public virtual DbSet<ApiResources> ApiResources { get; set; }
        public virtual DbSet<ApiScopeClaims> ApiScopeClaims { get; set; }
        public virtual DbSet<ApiScopes> ApiScopes { get; set; }
        public virtual DbSet<ApiSecrets> ApiSecrets { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<ClientClaims> ClientClaims { get; set; }
        public virtual DbSet<ClientCorsOrigins> ClientCorsOrigins { get; set; }
        public virtual DbSet<ClientGrantTypes> ClientGrantTypes { get; set; }
        public virtual DbSet<ClientIdPRestrictions> ClientIdPRestrictions { get; set; }
        public virtual DbSet<ClientPostLogoutRedirectUris> ClientPostLogoutRedirectUris { get; set; }
        public virtual DbSet<ClientProperties> ClientProperties { get; set; }
        public virtual DbSet<ClientRedirectUris> ClientRedirectUris { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientScopes> ClientScopes { get; set; }
        public virtual DbSet<ClientSecrets> ClientSecrets { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<EnvioEmail> EnvioEmail { get; set; }
        public virtual DbSet<EnvioLog> EnvioLog { get; set; }
        public virtual DbSet<IdentityClaims> IdentityClaims { get; set; }
        public virtual DbSet<IdentityProperties> IdentityProperties { get; set; }
        public virtual DbSet<IdentityResources> IdentityResources { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<ParametricaApp> ParametricaApp { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoNotificacion> TipoNotificacion { get; set; }
        public virtual DbSet<TipoPersona> TipoPersona { get; set; }
        public virtual DbSet<UsuarioTipoNotificacion> UsuarioTipoNotificacion { get; set; }
        public virtual DbSet<BackAspNetUsers> BackAspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnvioEmail>()
                .Property(e => e.Para)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioEmail>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioEmail>()
                .Property(e => e.Asunto)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioEmail>()
                .Property(e => e.ConCopia)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioEmail>()
                .Property(e => e.ConCopiaOculta)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioEmail>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ParametricaApp>()
                .Property(e => e.Parametro)
                .IsUnicode(false);

            modelBuilder.Entity<ParametricaApp>()
                .Property(e => e.Texto)
                .IsUnicode(false);

            modelBuilder.Entity<ParametricaApp>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<TipoNotificacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoNotificacion>()
                .HasMany(e => e.UsuarioTipoNotificacion)
                .WithRequired(e => e.TipoNotificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPersona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioTipoNotificacion>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioTipoNotificacion>()
                .Property(e => e.UsuarioModificacion)
                .IsUnicode(false);
        }
    }
}

