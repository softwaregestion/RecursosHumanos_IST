namespace IST.RRHH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnvioEmail")]
    public partial class EnvioEmail
    {
        public int Id { get; set; }

        public bool Enviado { get; set; }

        [StringLength(550)]
        public string Para { get; set; }

        [StringLength(2500)]
        public string Mensaje { get; set; }

        public string Obj { get; set; }

        public DateTime? Fechacreacion { get; set; }

        public DateTime? Fechaenvio { get; set; }

        [StringLength(250)]
        public string Asunto { get; set; }

        [StringLength(550)]
        public string ConCopia { get; set; }

        [StringLength(550)]
        public string ConCopiaOculta { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }
    }
}
