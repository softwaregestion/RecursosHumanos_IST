using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.Api.Helpers.App
{
    public class ReglasHelpers
    {
        public static DateTime Regla_CalcularFechaCreacionSolicitud(string turno, int horaSla)
        {
            DateTime fechaCompromiso = DateTime.Now.AddHours(24);

            //if (turno == Domain.eEnum.eeTurno.JornadaSemanal.ToString())
            //{
            //    switch (fechaCompromiso.DayOfWeek)
            //    {
            //        case DayOfWeek.Sunday:
            //        case DayOfWeek.Monday:
            //        case DayOfWeek.Tuesday:
            //        case DayOfWeek.Wednesday:
            //        case DayOfWeek.Thursday:
            //            fechaCompromiso = fechaCompromiso.AddHours(horaSla);
            //            break;
            //        case DayOfWeek.Friday:
            //            fechaCompromiso = fechaCompromiso.AddDays(2).AddHours(horaSla);
            //            break;
            //        case DayOfWeek.Saturday:
            //            fechaCompromiso = fechaCompromiso.AddDays(1).AddHours(horaSla);
            //            break;
            //    }
            //}
            //else if (turno == Domain.eEnum.eeTurno.Jornada24x7.ToString())
            //{
            //    fechaCompromiso = fechaCompromiso.AddHours(horaSla);
            //}
            //else
            //{ 
                
            //}

            return fechaCompromiso;


        }

        public static string GetClaimValue(List<RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Result> claim, string claimType)
        {
            var claimR = claim.SingleOrDefault(c => c.ClaimType == claimType);
            if (claimR != null)
            {
                return claimR.ClaimValue;
            }
            return "";
        }

        public static string GetClaimValue(List<RRHH.Domain.Query.ClientClaims.Index.GetAllByClientId.Result> claim, string claimType)
        {
            var claimR = claim.SingleOrDefault(c => c.Type == claimType);
            if (claimR != null)
            {
                return claimR.Value;
            }
            return "";
        }
    }
}
