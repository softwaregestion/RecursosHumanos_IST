using IST.RRHH;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Web.Helpers;
using IST.RRHH.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Controllers
{    
    [Authorize]
    public class MyAccountController : Controller
    {
        IMediator Mediator;        
        ICustomUserContext UserLogin;
        IServicio Servicio;

        public MyAccountController(IMediator iMediator, ICustomUserContext iCustomUserContext, IServicio servicio)
        {
            this.Mediator = iMediator;            
            this.UserLogin = iCustomUserContext;
            this.Servicio = servicio;
        }

        // GET: MyAccount
        public ActionResult Index()
        {


            return RedirectToAction("Admin", "User", new { UserId = UserLogin.UserId, returnx = "ok", msj = UserLogin.Mensaje });

            //OFF

            var user = new UserIndexModel();
            var user1 = this.Mediator.Query(new IST.RRHH.Domain.Query.AspNetUsers.Details.GetSingleItem.Query() { Id = UserLogin.UserId });
            
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
            user.Rol  = ReglasHelpers.GetClaimValue(claim, "app_role.Contratista");
            user.Telefono = ReglasHelpers.GetClaimValue(claim, "telefono");
            user.Cargo = ReglasHelpers.GetClaimValue(claim, "cargo");
            user.Direccion = ReglasHelpers.GetClaimValue(claim, "direccion");

            var roles = this.Servicio.CallGetService<List<Models.ParametricaData>>("ParametricaRoles"); 

            ViewBag.ddlRoles = roles;
             

            return View(user);
        }

        [HttpPost]
        public ActionResult Index(UserIndexModel model)
        {

            try
            {                

                if (string.IsNullOrEmpty(model.Rut))
                {
                    model.Rut = "";
                }

                if (string.IsNullOrEmpty(model.ApellidoPaterno))
                {
                    model.ApellidoPaterno = "";
                }

                if (string.IsNullOrEmpty(model.ApellidoMaterno))
                {
                    model.ApellidoMaterno = "";
                }

                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "nombres", ClaimValue = model.Nombres });
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "rut", ClaimValue = model.Rut });
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "apellido_paterno", ClaimValue = model.ApellidoPaterno });
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "apellido_materno", ClaimValue = model.ApellidoMaterno });
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "app_role.Contratista", ClaimValue = model.Rol  });

                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "telefono", ClaimValue = model.Telefono });
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "edad", ClaimValue = model.Edad });
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "direccion", ClaimValue = model.Direccion });

                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "cargo", ClaimValue = model.Cargo });
                
                this.Mediator.Command(new IST.RRHH.Domain.Command.AspNetUsers.EditEstados.Command() { Id = model.UserId, LockoutEnabled = model.Activo });

                //default notificación by rol
                                
                TempData["Success"] = "Se ha grabado correctamente.";

                return RedirectToAction("Index", "MyAccount");
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Error actualizando la información, {ex.Message}";

                return RedirectToAction("Index ", "MyAccount");
            }

        }




    }
}
