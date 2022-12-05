using IST.RRHH.Domain.Jobs;
using IST.RRHH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Domain.Jobs
{
    public class ProcesarEmailJobs
    {

        IBDContext context;

        public ProcesarEmailJobs(IBDContext context, IMediator mediator)
        {
            this.context = context;
        }

        public void Enviar()
        {   
            var obj = new EnviarEmailJobs(this.context);

            //var data = this.context.EnvioEmail.Where(c => c.Enviado == false).ToList();
            //if (data.Count() > 0)
            //{
            //    foreach (var item in data.Take(50))
            //    {
            //        //se envía email
            //        obj.SendMailJob(item.Para, item.Asunto, item.Mensaje, item.ConCopia);                   
                   
            //        item.Fechaenvio = DateTimeJacquard.Now;
            //        item.Enviado = true;
            //        this.context.SaveChanges();

            //    }
            //}

        }

    }
}
