using System;
using System.Collections.Generic;

namespace IST.Api.Models
{
    public class SolicitudApi
    {
        public List<SolicitudFlexibleApi> Items { get; set; }
        public string UserId { get;  set; }
        public string OrdenTrabajo { get;  set; }
        public string NumReserva { get;  set; }

        public List<SolicitudFlexibleFotos> Fotos { get; set; }
    }
    public class SolicitudFlexibleApi
    {
        public DateTime Fecha { get; set; }
        public string UserId { get; set; }
        public int? SolicitudMotivoId { get; set; }
        public int? SolicitudEstadoId { get; set; }
        public string NumParte { get; set; }
        public string STK { get; set; }
        public string OrdenTrabajo { get; set; }
        public int? Cantidad { get; set; }
        public string Equipo { get; set; }
        public string NumReserva { get; set; }
        public int? FaenaId { get; set; }
        public int? CentroId { get; set; }
        public int? AlmacenId { get; set; }
        public string NumSolicitud { get; set; }
        public int ProductoModeloId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string JsonProducto { get; set; }
        public Guid? SolicitudProductoId { get;  set; }
        public string NumeroInterno { get; set; }
    }

    public partial class SolicitudFlexibleFotos
    {
      
        public Guid SolicitudFlexibleId { get; set; }

        public DateTime? Fecha { get; set; }

      
        public string Tipo { get; set; }

        public string Json { get; set; }

        public string SolicitudProductoId { get; set; }
    }
}
