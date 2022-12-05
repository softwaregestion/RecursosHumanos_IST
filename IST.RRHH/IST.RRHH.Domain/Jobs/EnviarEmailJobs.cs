
using IST.RRHH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH.Domain.Jobs
{
    public class EnviarEmailJobs
    {

        IBDContext context;
        

        public EnviarEmailJobs(IBDContext context)
        {
            this.context = context;
        }

        public bool SendMailJob(string para, string asunto, string mensaje, string cc = "")
        {


            var bsPAram = context.ParametricaApp.Where(c => c.Parametro == "Email").ToList();
            if (bsPAram.Count > 0)
            {
                var util = new Email();
                try
                {
                    if (para == "usaradministrador")
                    {
                        para = bsPAram.Single(c => c.ParametricaId == (int)eParametricas.Email_ParaAdmin).Valor;
                    }

                    util.smtp = bsPAram.Single(c => c.ParametricaId == (int)eParametricas.Email_Smtp).Valor;
                    util.emailOrigen = bsPAram.Single(c => c.ParametricaId == (int)eParametricas.Email_User).Valor;
                    util.passwordOrigen = bsPAram.Single(c => c.ParametricaId == (int)eParametricas.Email_Password).Valor;
                    util.port = int.Parse(bsPAram.Single(c => c.ParametricaId == (int)eParametricas.Email_Port).Valor);
                    util.enableSsl = bool.Parse(bsPAram.Single(c => c.ParametricaId == (int)eParametricas.Email_EnableSsl).Valor);

                    return util.EnviarEmail(para, asunto, mensaje);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                return false;

        }
    }
}
