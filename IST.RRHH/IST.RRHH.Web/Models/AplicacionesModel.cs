using IST.RRHH.Domain.Query.Clients.Index;
using IST.RRHH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Models
{
    public class AplicacionesModel
    {
        // public List<GetAll.Result> Aplicaciones { get;  set; }
        public List<GetAllCountUser.Result> Aplicaciones { get;  set; }
        public List<AplicacionesModelUsers> Usuarios { get; set; }
        public List<AspNetUserClaims> UserApp { get;  set; }
        public List<Domain.Query.EnvioEmail.Index.GetAll.Result> Mensajes { get;  set; }

        //public List<Domain.Query.Log.Index.GetAllByUser.Result> Log { get; set; }

        public List<ClientClaims> Roles { get;  set; }
        public int ClientId { get; internal set; }
        public string UserId { get; internal set; }
        public List<Domain.Query.ParametricaApp.Index.GetAll.Result> ParametricaApp { get; internal set; }
        public List<Domain.Query.Cargo.Index.GetAll.Result> Cargos { get; internal set; }
    }

    public class ModelRol
    {
        public string Nombre { get; set; }

        public string Clients { get; set; }


    }

    public class Mensaje
    {
        public string Mail { get; set; }
        public string Area { get; set; }
        public string UserId { get;  set; }
        public List<Domain.Query.ParametricaApp.Index.GetAll.Result> ParametricaApp { get;  set; }
    }

    public class ModelClients
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UrlHost { get; set; }
        public string Password { get; set; }

        public bool NetCore { get; set; }
    }


    public class AplicacionesModelUsers
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Rut { get; set; }
        public string Rol { get; set; }
        public List<ModelClients> Clients { get; set; }
        public List<ModelRol> Rols { get; set; }
        public List<string> AppSystem { get; set; }
        //public List<ClientClaims> Roles { get; set; }
        //public List<Clients> App { get; internal set; }
        public List<ModelClients> ClientsAdminUser { get; set; }
        public string AppSolicitado { get; set; }
        public bool IsMobile { get; set; }
        public string recoveryId { get; set; }
        public string Codigo { get; set; }
        public string Contrasena { get; set; }
        public string ContrasenaConfirmacion { get; set; }

        public string Tipo { get; set; }
    }

      
}
