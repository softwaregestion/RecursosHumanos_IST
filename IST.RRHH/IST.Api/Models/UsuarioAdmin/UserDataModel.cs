using System.Collections.Generic;

namespace IST.Api.Models
{
    public class UserIndexModel
    {
        public string UserId { get; internal set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Nombres { get; set; } 
        public bool Activo { get;  set; }
        public string Rol { get; set; }
        public string Rut { get; set; }        
        public string Fecha { get;  set; }        
        public string Estado { get;  set; } 
    }

    public class ClientDataModel
    {
        public string Nombre { get; set; }
    
        public string ClientId { get;  set; }
        public List<RRHH.Domain.Query.ClientClaims.Index.GetAllByClientId.Result> ListadoClaims { get;  set; }
        public string TimeOut { get;  set; }
        public string Icono { get;  set; }
        public string Descripcion { get;  set; }
    }
    public class UserDataModel
    {
    

        public string UserName { get;  set; }
        public string Email { get;  set; }
        public bool Activo { get;  set; } 
        public string Nombres { get;  set; }
        public string FechaCreacion { get;  set; } 
        public string ApellidoMaterno { get;  set; }
        public string ApellidoPaterno { get;  set; }
        public string Rut { get;  set; }
        public string Rol { get;  set; }
        public string UserId { get;  set; }

        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        
        public string Estado { get;  set; }
        public string Id { get;   set; }
        public string Cargo { get;   set; }
        public string Celular { get;  set; }
        public string ProximaRenovacionPassword { get;  set; }

        public string Firma { get; set; }
        public string Foto { get; set; }
        public string Contrato { get; set; }

        public string Email2 { get; set; }
        public string FechaCumpleanos { get;  set; }
    }

    //public class UserDataRelacion
    //{
    //    public int Id { get; set; }

    //}
}
