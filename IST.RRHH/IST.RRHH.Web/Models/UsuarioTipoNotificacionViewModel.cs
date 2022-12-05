using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Models
{
    public class UsuarioTipoNotificacionViewModel
    {
        public string UserId { get; set; }


        public int TipoNotificacionId { get; set; }

        public DateTime UltimaModificacion { get; set; }


        public string UsuarioModificacion { get; set; }
    }
}
