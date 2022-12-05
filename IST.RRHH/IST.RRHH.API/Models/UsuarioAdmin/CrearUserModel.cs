using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.API.Models
{
    public class CrearClientModel
    {
        public int ClientId { get; set; }
        public string Nombre { get; set; }

        public string TimeOut { get; set; }

        public string Icono { get; set; }

        public string Descripcion { get; set; }
    }

    public class CrearUserModel
    {
        public string[] ListadoAutorizacion { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public bool SolicitarPermiso { get; set; }
        public string Nombres { get; set; }
        public string FechaCreacion { get; set; }

        public string FechaCumpleanos { get; set; }
        public string ClienteId { get; set; }

        public string ContratoId { get; set; }
        public string FaenaSolicitante { get; set; }
        public string EmpresaSolicitante { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string Rut { get; set; }
        public string RolFlexible { get; set; }
        public string UserId { get; set; }

        public string Estado { get; set; }
        public string Telefono { get;  set; }

        public string Edad { get;  set; }
        public string Direccion { get;  set; }
        public string Jerarquia { get;  set; }

        public string Cargo { get; set; }
        public string Celular { get; set; }


        public string Firma { get; set; }
        public string Contrato { get; set; }
        public string Foto { get; set; }

        public string ProximaRenovacionPassword { get; set; } 
    }
}
