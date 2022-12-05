

using IST.RRHH.Web;
using Jacquard.SSO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace IST.SSO.Api.Data
{
     

    public class Contexto :  DbContext
    {
        //Constructor sin parametros
        public Contexto()
        {
        }

        //Constructor con parametros para la configuracion
        public Contexto(DbContextOptions<Contexto> options)
        : base(options)
        {
        }

        //Sobreescribimos el metodo OnConfiguring para hacer los ajustes que queramos en caso de
        //llamar al constructor sin parametros
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AppConfig.ConnectionString + ";MultipleActiveResultSets=True;App=EntityFramework");
            }
        }

        //Tablas de datos
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        public virtual DbSet<Clients> Clients { get; set; }

        public virtual DbSet<ClientScopes> ClientScopes { get; set; }

        public virtual DbSet<ClientClaims> ClientClaims { get; set; }

        public virtual DbSet<ClientSecrets> ClientSecrets { get; set; }
    }
}
