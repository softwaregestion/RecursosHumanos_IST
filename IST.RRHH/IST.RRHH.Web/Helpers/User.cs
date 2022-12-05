using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Models;
using Jacquard.SSO.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Helpers
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }
    }

   

    public class UserContext : ICustomUserContext
    {        
        public string UserLogin { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }
        public string UserId { get; set; }
        public string SubjectId { get; set; }
        public string[] Roles { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAdmin { get; set; }

        public string UserRole { get; set; }

        public string NombreCompleto { get; set; }

        public string PointSeparatedName { get; set; }

        public string Mensaje { get; set; }
        public UserContext(IPrincipal principal)
        {            
            var user = (principal as ClaimsPrincipal);

            if (user != null )
            {
                if (user.Identities.ToList().Count > 0)
                {
                    try
                    {
                        var ident = user.Identities.ToList()[1] as System.Security.Claims.ClaimsIdentity;
                        AccessToken = ident.Claims.FirstOrDefault(c => c.Type == "access_token").Value;
                        SubjectId = user.Identities.ToList()[0].FindFirst("sub").Value;
                        Roles = user.FindAll("role").Select(x => x.Value).ToArray();
                        UserRole = user.FindFirst("app_role.Contratista")?.Value;
                        Name = user.FindFirst("name")?.Value;
                        Email = user.FindFirst("email")?.Value;
                        UserId = user.Identities.ToList()[0].FindFirst("sub").Value;
                        IsAuthenticated = true;
                        if (UserRole == "Administrador")
                        {
                            IsAdmin = true;
                        }
                        else
                        {
                            IsAdmin = false;
                        }

                        Mensaje = "ok";

                        //NombreCompleto = user.FindFirst("nombres").Value + " " + user.FindFirst("apellido_paterno").Value; ;
                    }
                    catch (Exception ex) 
                    {
                        //throw ex;
                        UserId = Guid.Empty.ToString();
                        UserLogin = "annonymous";
                        Name = "jacquard spa.";
                        Mensaje = ex.Message;
                    }
                   
                }
                else
                { 
                    UserId = Guid.Empty.ToString();
                    UserLogin = "annonymous";
                    Name = "jacquard spa.";

                    Mensaje = user.Identities.ToList().Count.ToString();
                }
            }
            else
            {

                UserId = Guid.Empty.ToString();
                UserLogin = "annonymous";
                Name = "jacquard spa.";

                Mensaje = "blank";
            }
        }

    }


    public interface ICustomUserContext
    {
        bool IsAdmin
        {
            get;
        }
        
        bool IsAuthenticated
        {
            get;
        }

        string Name
        {
            get;
        }

        string[] Roles
        {
            get;
        }

        string SubjectId
        {
            get;
        }

        string UserId
        {
            get;
        }

        string UserLogin
        {
            get;
        }

        string AccessToken { get; set; }

        string NombreCompleto { get; }
        string UserRole { get; }

        string Mensaje { get; }
    }

    public class ModelUsers
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
        public List<Model.ClientClaims> Roles { get; set; }
        public List<Model.Clients> App { get; internal set; }
        
        public List<ModelClients> ClientsAdminUser { get; set; }
        public string AppSolicitado { get; set; }
        public bool IsMobile { get; set; }
        public string recoveryId { get; set; }
        public string Codigo { get; set; }
        public string Contrasena { get; set; }
        public string ContrasenaConfirmacion { get; set; }
        public List<Clients> ClientsApp { get; internal set; }
    }

    public class ModelClients
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UrlHost { get; set; }
        public string Password { get; set; }

        public bool NetCore { get; set; }
    }


    public class ModelRol
    {
        public string Nombre { get; set; }

        public string Clients { get; set; }


    }
}
