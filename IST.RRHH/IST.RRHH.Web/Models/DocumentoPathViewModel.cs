using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Models
{
    public class DocumentoPathViewModel
    {
        public string Path { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public Guid? GestorDocumentalContratistaDocumentoId { get; set; }
    }
}
