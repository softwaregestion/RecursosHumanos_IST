using System;
using IST.Api.Helpers;
using IST.RRHH;
using IST.RRHH.Domain.eEnum;
using IST.RRHH.Domain.Jobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IST.Api.Controllers
{
    [Route("api/UserCambioPassword")]
    [AllowAnonymous]
    public class UserCambioPasswordController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public UserCambioPasswordController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        

        [HttpGet]
        public IActionResult Get(string id)
        {
            var recoveryId = Guid.NewGuid();

            this.Context.Command(new RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = id, ClaimType = "_recovery", ClaimValue = recoveryId.ToString() });

            var users = Context.Query(new RRHH.Domain.Query.AspNetUsers.Edit.GetSingleItem.Query() { Id = id });


            this.Email.SendMail(users.Email, "Enlace para cambio contraseña", string.Format(@"Estimado/a, {0}
                                                                            <br/><br/> 
                                                                            Se ha solicitado el cambio de su contraseña,  para continuar haga click en el siguiente <a href='" + IST.Api.AppConfig.UrlWeb + @"/recovery/recoverynewpassword/{2}?recoveryid={1}'>enlace</a> 
                                                                            <br/><br/> 
                                                                            El código de validación es: <strong> {3} </strong>
                                                                            <br/><br/> 
                                                                            <strong>No responder mail generado automaticamente.</strong>                                                                            
                                                                            ", users.UserName, 
                                                                            recoveryId, 
                                                                            id, 
                                                                            recoveryId.ToString().Substring(0,4).ToLower()
                                                                            ), TipoMensajeria.Mail);


            return Ok("Ok");



            return new JsonResult("OK");
        }

        
    }
}
