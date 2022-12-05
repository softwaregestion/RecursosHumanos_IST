using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IST.RRHH.Web.Controllers
{
    [AllowAnonymous]
    //[Authorize]
    public class AplicacionesRolesController : Controller
    {
        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;

        public AplicacionesRolesController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio)
        {
            this.Mediator = iMediator;
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
        }

 

        [HttpGet]
        public IActionResult IndexRoles (int? id)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });


            
            model.UserApp = context.AspNetUserClaims.Where(c => c.ClaimType == "application").ToList();

            if (id != null)
            {
                model.ClientId = id.Value;

                if (model.Aplicaciones.Any(c => c.Id == id.Value))
                {
                    var clientid = model.Aplicaciones.SingleOrDefault(c => c.Id == id.Value);
                    if (clientid != null)
                    {
                        var x = context.ClientClaims.Where(c => c.ClientId ==  clientid.Id && c.Type == "Rol").ToList();
                        if (x.Count > 0)
                        {
                            model.Roles = x;
                        }
                        else
                        {
                            model.Roles = new List<Model.ClientClaims>();
                        }
                    }
                    else
                    {
                        model.Roles = new List<Model.ClientClaims>();
                    }
                }
            }
            //else
            //{
            //    model.Usuarios = new List<AplicacionesModelUsers>();
            //}            

            return View(model);
        }

        [HttpGet]
        public IActionResult IndexEditar(int? id)
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });



            model.UserApp = context.AspNetUserClaims.Where(c => c.ClaimType == "application").ToList();

            if (id != null)
            {
                model.ClientId = id.Value;

                if (model.Aplicaciones.Any(c => c.Id == id.Value))
                {
                    var clientid = model.Aplicaciones.SingleOrDefault(c => c.Id == id.Value);
                    if (clientid != null)
                    {
                        var x = context.ClientClaims.Where(c => c.ClientId == clientid.Id && c.Type == "Rol").ToList();
                        if (x.Count > 0)
                        {
                            model.Roles = x;
                        }
                        else
                        {
                            model.Roles = new List<Model.ClientClaims>();
                        }
                    }
                    else
                    {
                        model.Roles = new List<Model.ClientClaims>();
                    }
                }
            }
            //else
            //{
            //    model.Usuarios = new List<AplicacionesModelUsers>();
            //}            

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Up(string msj)
        {
            
            return View(new { msj = msj });
        }
    }
}
