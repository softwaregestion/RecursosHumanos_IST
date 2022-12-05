using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IST.RRHH.API.Helpers;
using IST.RRHH.API.Models;
using IST.RRHH.Domain.Jobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH.Domain;
using IST.RRHH.Domain.eEnum;

namespace IST.RRHH.API.Controllers
{
    [Route("api/usercreatedefaultpassword")]
    [AllowAnonymous]
    public class UserCreateDefaultPassword : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public UserCreateDefaultPassword(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        

        [HttpGet]
        public IActionResult Get(string id)
        {
            var recoveryId = Guid.NewGuid();


            this.Context.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = id, ClaimType = "_recovery", ClaimValue = recoveryId.ToString() });

            var users = Context.Query(new Domain.Query.AspNetUsers.Edit.GetSingleItem.Query() { Id = id });


            this.Email.SendMail(users.Email, "Nueva cuenta Registrada", string.Format(@"Sr/a, {0}
            <br/><br/> 
            Se ha registrado la creación de su cuenta '{0}' en el sistema IST,  para continuar haga click en el siguiente <a href='" + IST.RRHH.API.AppConfig.UrlWeb + @"/recovery/recoverynewpassword/{2}?recoveryid={1}'>enlace</a> para asignar contraseña
            <br/><br/> 
            <br/><br/> 
            El código de validación es: <strong> {3} </strong>
            <br/><br/> 
            <strong>No responder mail generado automaticamente.</strong>"
, users.UserName, recoveryId, id, recoveryId.ToString().Substring(0, 4).ToLower()), TipoMensajeria.Mail);




            return Ok("Ok");



            return new JsonResult("OK");
        }

        
    }
}
