using IST.RRHH.Domain.eEnum;
using IST.RRHH.Domain.Jobs;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IST.RRHH.Web.Controllers
{
    [AllowAnonymous]
    //[Authorize]
    public class MensajeController : Controller
    {
        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;
        IEmailJobs Email;

        public MensajeController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio, IEmailJobs mail)
        {
            this.Mediator = iMediator;
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
            this.Email = mail;
        }


        public IActionResult Index(string Id )
        {
            var model = new Mensaje();
            model.UserId = Id;

            if (!string.IsNullOrEmpty(Id))
            {
                var users = Mediator.Query(new Domain.Query.AspNetUsers.Edit.GetSingleItem.Query() { Id = model.UserId });
                model.Mail = users.Email;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Mensaje model)
        {

            var recoveryId = Guid.NewGuid();


            
            var users = Mediator.Query(new Domain.Query.AspNetUsers.Edit.GetSingleItem.Query() { Id = model.UserId });


            this.Email.SendMail(users.Email, "Nueva cuenta Registrada", string.Format(@"Sr/a, {0}
                                                                            <br/><br/> 
                                                                           Se le ha enviado desde RRHH el siguiente mensaje: {1}
                                                                            <strong>No responder mail generado automaticamente.</strong>                                                                                                                                                      
                                                                           
                                                                            ", users.UserName, model.Area), TipoMensajeria.Mail);




            return Ok("Ok");



            return View(model);
        }

        
    }
}
