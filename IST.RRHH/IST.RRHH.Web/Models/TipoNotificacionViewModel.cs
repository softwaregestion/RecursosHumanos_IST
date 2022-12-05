using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Models
{
    public class TipoNotificacionViewModel
    {
        public int TipoNotificacionId { get; set; }


        public string Nombre { get; set; }
        public string ContenidoPlantilla { get; set; }
        public List<TipoNotificacionViewModel> ListaTipoNotificacion { get; set; }
    }
}
