using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IST.RRHH.API.Helpers;

using Emsesa.Models.Nuevo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using IST.RRHH.Domain;
using IST.RRHH.Domain.eEnum;
using IST.RRHH.Domain.Jobs;

namespace Emsesa.Models.Nuevo
{
    public class RecoveryUsuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Guid RecoveryId { get; set; }
    }
}


namespace IST.RRHH.API.Controllers
{
    [Route("api/enviarmailrecovery")]
    [AllowAnonymous]
    public class EnviarMailRecoveryController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public EnviarMailRecoveryController(IMediator context, ICustomUserContext user, IEmailJobs Email) {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] RecoveryUsuario model)
        {
            var users = Context.Query(new Domain.Query.AspNetUsers.Edit.GetSingleItem.Query() { Id = model.Id });


            this.Email.SendMail(users.Email, "Solicitado de restablecer contraseña", string.Format(@"Sr/a, {0}
                                                                            <br/><br/> 
                                                                            Se ha solicitado la recuperación de su contraseña,  para continuar haga click en el siguiente <a href='" + IST.RRHH.API.AppConfig.UrlSSO+ @"/recoverynewpassword/{2}?recoveryid={1}'>enlace</a>  <br/><br/> 
                                                                            El código de validación es: <strong> {3} </strong>                                                                            
                                                                            <br/><br/> 
                                                                            <strong>No responder mail generado automaticamente.</strong>                                                                            
                                                                            ", users.UserName, model.RecoveryId, model.Id,
                                                                            model.RecoveryId.ToString().Substring(0, 4).ToLower()), TipoMensajeria.Mail);


            return Ok("Ok");
        }
    }
}