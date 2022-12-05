using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Models
{
    public class ClientIndexModel
    {
        public string ClientId { get;  set; }

        public string Nombre { get; set; }

        public string TimeOut { get; set; }

        public string Icono { get; set; }

        public string Descripcion { get; set; }

        public List<ClientIndexDataModel> Items { get;  set; }
    }

    public class UserIndexModel : UserIndexDetailsModel
    {
        public string[] ListadoAutorizacion { get; set; }

        public string jsonListadoAutorizacion { get; set; }
        public List<UserIndexDataModel> Items { get; set; }
        public List<ParametricaData> ddlRoles { get; set; }

        public List<ParametricaData> ddlCargo { get; set; }
        public List<Cumpleanos> Cumpleanos { get; set; }

        public int CountAppUser { get; set; }
        public int CountApp { get; set; }
        public int CountUser { get; set; }
        public int CountMensaje { get; set; }

        public List<int> FechasCreacionContador { get; set; }


    }
    public class CountCumpleanos
    {
        public int Mes { get; set; }

        public int Total { get; set; }
    }

    public class Cumpleanos
    {
        public DateTime Fecha { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }
    }

   

    public class UserIndexDataModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Nombres { get; set; }
        public bool Activo { get; set; }
        public string Rol  { get; set; }
        public string Rut { get; set; }
        public string Fecha { get; set; }
         
    }

    public class ClientIndexDataModel
    {
        public string ClientId { get; set; }
        public string Nombre{ get; set; }

        public List<Domain.Query.ClientClaims.Index.GetAllByClientId.Result> ListadoClaims { get;  set; }

    }



    public class UserIndexDetailsModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public string Nombres { get; set; }
        public string FechaCreacion { get; set; } 
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public string Celular { get; set; }
        public string Edad { get; set; }
        public string Cargo { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string Rut { get; set; }
        public string Rol  { get; set; }
        public string UserId { get; set; }
        public string Estado { get; set; }
        public string Fecha { get; set; }

        public string FechaCumpleanos { get; set; }

        public string FechaNacimiento { get; set; }
        public int? UserMax { get; set; }
         
       public List<ParametricaData> TipoNotificacion { get; set; }

        public string Firma { get; set; }
        public string Foto { get; set; }
        public string Contrato { get; set; }

        public string Email2 { get; set; }
    }

    public class UserDataRelacion
    {
        public int Id { get; set; }

    }

    public class ParametricaData
    {
        public string ParentId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class Chart { 
    
        public Height height { get; set; }
    }
    public class Height
    {
        public string type { get; set; }

        public string offsetY { get; set; }
    }

    public class plotOptions
    {
        public RadialBar radialBar { get; set; }

        public string offsetY { get; set; }

        public string[] colors { get; set; }

        public string[] series { get; set; }

        public string[] labels { get; set; }

    }

    public class RadialBar
    {
        public string startAngle { get; set; }

        public string endAngle { get; set; }

        public DataLabels dataLabels { get; set; }
    }


    public class DataLabels
    {
        public NameValue name { get; set; }

        public NameValue value { get; set; }
    }

    public class Stroke
    {
        public int dashArray { get; set; }

         
    }



    public class NameValue
    {
        public string fontSize { get; set; }
        public string color { get; set; }

        public string offsetY { get; set; }

        public string formatter { get; set; }
        
    }


}
