using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System.Collections.Generic;
using IdentityModel.Client;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using IST.RRHH.API.Models;
using IST.RRHH.Domain;
using IST.RRHH.Domain.Jobs;
using IST.RRHH.API;

namespace IST.RRHH.Web.API.Controllers
{
    [Route("api/test")]
    [AllowAnonymous]
    public class TestController : ControllerBase
    {
        IEmailJobs EmailJobs;
        public TestController(IEmailJobs emailJobs) {
            EmailJobs = emailJobs;
        }
        public  IActionResult Get()
        {   
            //var u = getClaims();
            string[] roles = new string[] { "Usuario", DateTime.Now.ToString(), Domain.Startup.Path , AppConfig.UrlSSO, AppConfig.UrlApi };


            //EmailJobs.SendMail("kris.ibacache@gmail.com", "prueba correo", "mensaje...", Domain.eEnum.TipoMensajeria.Mail);
            //var user = GetUserInfoAsync();
            //if (user != null)
            //{
            //    var app = user.Claims.FirstOrDefault(c => c.Type == "client_id");
            //    //var context = new ACCESOEntities();

            //    var context = new Contexto();
            //   var data = context.AspNetUserClaims.Where(c => c.UserId == user.sub.ToString());

            //    if (data != null)
            //    {
            //        var application = data.SingleOrDefault(c => c.ClaimType == "application" && c.ClaimValue == app.Value.ToString());
            //        if (application != null)
            //        {
            //            roles = data.Where(c => c.ClaimType == "app_role." + app.Value).Select(c => c.ClaimValue).ToArray();
            //        }

            //    }




            //}


            return new JsonResult(roles);

        }

    }
}
