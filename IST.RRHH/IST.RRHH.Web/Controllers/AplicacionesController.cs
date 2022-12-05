using IST.RRHH;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Controllers
{
    [AllowAnonymous]
    //[Authorize]
    public class AplicacionesController : Controller
    {
        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;

        public AplicacionesController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio)
        {
            this.Mediator = iMediator;
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
        }


        public IActionResult Index()
        {
            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });    

        


            return View(model);
        }

        public IActionResult IndexPorRol()
        {
            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });




            return View(model);
        }

        public IActionResult Config()
        {
            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });

            return View(model);
        }

        public IActionResult IndexUser() 
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Aplicaciones = Mediator.Query(new IST.RRHH.Domain.Query.Clients.Index.GetAllCountUser.Query() { });

            var data = (from user in context.AspNetUsers
                        join apellidos in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "apellido_paterno" } equals new { apellidos.UserId, apellidos.ClaimType }
                        join nombres in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "nombres" } equals new { nombres.UserId, nombres.ClaimType }
                        join rut in context.AspNetUserClaims on new { UserId = user.Id, ClaimType = "rut" } equals new { rut.UserId, rut.ClaimType }
                        select new AplicacionesModelUsers { Id = user.Id, Username = user.UserName, Nombres = nombres.ClaimValue, Apellidos = apellidos.ClaimValue, Email = user.Email, Rut = rut.ClaimValue }).ToList();

            if (data.Count > 0)
            {
                model.Usuarios = data;
            }

            return View(model);
        }

          public IActionResult Mensajes() 
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Mensajes = Mediator.Query(new IST.RRHH.Domain.Query.EnvioEmail.Index.GetAll.Query() { });

         

            return View(model);
        }

        //public IActionResult Logs()
        //{
        //    var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

        //    var model = new AplicacionesModel();
        //    model.Log = Mediator.Query(new IST.RRHH.Domain.Query.Log.Index.GetAllByUser.Query() { UserId = UserLogin.UserId });


        //    return View(model);
        //}


        public IActionResult Cargos()
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            model.Cargos = Mediator.Query(new IST.RRHH.Domain.Query.Cargo.Index.GetAll.Query() {   });


            return View(model);
        }



        public IActionResult Parametricas()
        {
            var context = new IST.RRHH.Model.Context(AppConfig.ConnectionString);

            var model = new AplicacionesModel();
            var ParametricaApp = Mediator.Query(new Domain.Query.ParametricaApp.Index.GetAll.Query());
            model.ParametricaApp = ParametricaApp;
             
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
