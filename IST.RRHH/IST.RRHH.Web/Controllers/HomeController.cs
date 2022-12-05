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
    [Authorize()]
    public class HomeController : Controller
    {
        IMediator Mediator;
        ICustomUserContext UserLogin;
        IServicio Servicio;

        public HomeController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio)
        {
            this.Mediator = iMediator;
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
        }


        public IActionResult Index()
        {

            string strName = Contants.LAYOUT_VERTICAL;
            string strWelcomeText = "Dashboard";

            if (TempData["ModeName"] != null)
                strName = TempData["ModeName"].ToString();

            if (TempData["WelcomeText"] != null)
                strWelcomeText = TempData["WelcomeText"].ToString();

            ViewBag.ModeName = strName;
            ViewBag.WelcomeText = strWelcomeText;

            var user = new UserIndexModel();
            var user1 = this.Mediator.Query(new IST.RRHH.Domain.Query.AspNetUsers.Details.GetSingleItem.Query() { Id = UserLogin.UserId });
            if (user1 != null)
            {
                user.Email = user1.Email;
                user.UserId = user1.Id;
                user.UserName = user1.UserName;
                user.Activo = user1.LockoutEnabled;

                var claim = this.Mediator.Query(new IST.RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = user.UserId });

                user.Nombres = ReglasHelpers.GetClaimValue(claim, "nombres");
                user.ApellidoPaterno = ReglasHelpers.GetClaimValue(claim, "apellido_paterno");
                user.ApellidoMaterno = ReglasHelpers.GetClaimValue(claim, "apellido_materno");
                user.Rut = ReglasHelpers.GetClaimValue(claim, "rut");

                user.Fecha = ReglasHelpers.GetClaimValue(claim, "fecha_Creacion");
                user.Estado = ReglasHelpers.GetClaimValue(claim, "estado");
                user.Rol = ReglasHelpers.GetClaimValue(claim, "app_role." + AppConfig.ClientId);
                user.Telefono = ReglasHelpers.GetClaimValue(claim, "telefono");
                user.Cargo = ReglasHelpers.GetClaimValue(claim, "cargo");
                user.Direccion = ReglasHelpers.GetClaimValue(claim, "direccion");
                user.FechaNacimiento = ReglasHelpers.GetClaimValue(claim, "fecha_Cumpleanos");
                var roles = this.Servicio.CallGetService<List<Models.ParametricaData>>("ParametricaRoles");

                var cumples = Mediator.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByClaimValue.Query() { ClaimValue = DateTime.Today.ToString("dd-MM-yyyy hh:mm:ss"), ClaimType = "fecha_Cumpleanos" });

                var fechainicio = DateTime.Today;
                var fechafin = DateTime.Today.AddDays(10);

                user.Cumpleanos = new List<Cumpleanos>();
                for (DateTime i = fechainicio; i < fechafin; i = i.AddDays(1))
                {
                    cumples = Mediator.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByClaimValue.Query() { ClaimValue = i.ToString("dd-MM"), ClaimType = "dia_cumpleanos" });
                    foreach (var item in cumples)
                    {
                        var claimCumpleañeros = this.Mediator.Query(new IST.RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = item.UserId });
                        user.Cumpleanos.Add(new Cumpleanos() { Fecha = i, Nombre = $"{ReglasHelpers.GetClaimValue(claim, "nombres")} {ReglasHelpers.GetClaimValue(claim, "apellido_paterno")} " , Email =  ReglasHelpers.GetClaimValue(claim, "email_ref")} );
                    }
                }

                var creaciones = Mediator.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByClaimType.Query() { ClaimType = "fecha_Creacion" });
                user.FechasCreacionContador = new List<int>();

                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-01-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-02-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-03-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-04-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-05-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-06-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-07-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-08-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-09-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-10-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-11-"+DateTime.Today.Year  )));
                user.FechasCreacionContador.Add(creaciones.Count(c => c.ClaimValue.Contains($"-12-"+ DateTime.Today.Year)));



                ViewBag.ddlRoles = roles;

                var clients = Mediator.Query(new Domain.Query.Clients.Index.GetAllCountUser.Query());
                var msj = Mediator.Query(new Domain.Query.EnvioEmail.Index.GetAllId.Query());
                user.CountApp = clients.Count();
                user.CountUser = clients.Sum(c=>c.CuantosUsuarios);
                user.CountMensaje = msj.Count();

            }
            else
            {
                ViewBag.ddlRoles = new List<Models.ParametricaData>();
                user.Cumpleanos = new List<Cumpleanos>();
                user.FechasCreacionContador = new List<int>();
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);
                user.FechasCreacionContador.Add(0);

            }

            return View(user);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Up(string msj)
        {
            
            return View(new { msj = msj });
        }
    }
}
