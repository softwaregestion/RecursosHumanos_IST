using IST.RRHH.Domain.Jobs;
using IST.RRHH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Domain.Jobs
{
    public interface IEmailJobs
    {
        void SendMail(string para, string asunto, string mensaje, RRHH.Domain.eEnum.TipoMensajeria push);
    }


    public class CrearEmailJobs: IEmailJobs
    {
        IBDContext context;

        public CrearEmailJobs(IBDContext context)
        {
            this.context = context;
        }

        public void SendMail(string para, string asunto, string mensaje, RRHH.Domain.eEnum.TipoMensajeria push)
        {

             new EnviarEmailJobs(this.context).SendMailJob(para, asunto, mensaje);
            try
            {
                var email = this.context.EnvioEmail.Add(new EnvioEmail { Asunto = asunto, Enviado = false, Fechacreacion = DateTime.Now, Mensaje = mensaje, Para = para, Tipo = push.ToString() });
                this.context.SaveChanges();
            }
            catch (Exception)
            {


            }
        }


    }
}
