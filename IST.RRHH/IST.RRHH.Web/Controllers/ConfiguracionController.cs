using IST.RRHH.Domain.Jobs;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Controllers
{
    [AllowAnonymous]
    //[Authorize]
    public class ConfiguracionController : Controller
    {
        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;
        IEmailJobs Email;

        public ConfiguracionController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio, IEmailJobs mail)
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
                var ParametricaApp = Mediator.Query(new Domain.Query.ParametricaApp.Index.GetAll.Query());
                model.ParametricaApp = ParametricaApp;
            }

            return View(model);
        }

         

        
    }
}
