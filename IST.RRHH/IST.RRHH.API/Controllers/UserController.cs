using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using IST.RRHH.API.Helpers;
using IST.RRHH.API.Helpers.App;
using IST.RRHH.API.Models;
using IST.RRHH.Domain.Jobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH.Domain;

namespace IST.RRHH.API.Controllers
{
    [Route("api/user")]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public UserController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        

        [HttpGet]
        public IActionResult Get(string id)
        {
            var userAsp = this.Context.Query(new Domain.Query.AspNetUsers.Details.GetSingleItem.Query() { Id = id });
            var claim = this.Context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = id });
            var model = new UserDataModel();
            model.UserId = userAsp.Id;
            model.UserName = userAsp.UserName;
            model.Email = userAsp.Email;
            model.Activo = userAsp.LockoutEnabled;
            model.Nombres = ReglasHelpers.GetClaimValue(claim, "nombres");
            model.ApellidoMaterno = ReglasHelpers.GetClaimValue(claim, "apellido_materno");
            model.ApellidoPaterno = ReglasHelpers.GetClaimValue(claim, "apellido_paterno");
            model.Rut = ReglasHelpers.GetClaimValue(claim, "rut");
            model.Telefono = ReglasHelpers.GetClaimValue(claim, "telefono");
            model.Celular = ReglasHelpers.GetClaimValue(claim, "celular");
            model.Direccion = ReglasHelpers.GetClaimValue(claim, "direccion");            
            model.FechaCreacion = ReglasHelpers.GetClaimValue(claim, "fecha_Creacion");
            model.Rol = ReglasHelpers.GetClaimValue(claim, "app_role." + AppConfig.ClientId);
            model.Id = ReglasHelpers.GetClaimValue(claim, "app_role.Id");
            model.Estado = ReglasHelpers.GetClaimValue(claim, "estado") == "" ? "Solicitado" : ReglasHelpers.GetClaimValue(claim, "estado");
            model.Cargo = ReglasHelpers.GetClaimValue(claim, "cargo");

            model.Contrato = ReglasHelpers.GetClaimValue(claim, "contrato");
            model.Foto = ReglasHelpers.GetClaimValue(claim, "foto");
            model.Firma = ReglasHelpers.GetClaimValue(claim, "firma");
            model.Email2 = ReglasHelpers.GetClaimValue(claim, "email2");

            model.FechaCumpleanos = ReglasHelpers.GetClaimValue(claim, "fecha_Cumpleanos");

            model.ProximaRenovacionPassword = ReglasHelpers.GetClaimValue(claim, "ProximaRenovacionPassword");

            if (string.IsNullOrEmpty(model.Cargo))
            {
                model.Cargo = "0";
            }



            return new JsonResult(model);
        }

       

        [HttpPost]
        public IActionResult Post([FromBody]CrearUserModel model)
        {

            try
            {
                if (string.IsNullOrEmpty(model.ContratoId))
                {
                    model.ContratoId = "";
                }

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

                if (string.IsNullOrEmpty(model.RolFlexible))
                {
                    model.RolFlexible = "";
                }

                if (string.IsNullOrEmpty(model.ClienteId))
                {
                    model.ClienteId = "";
                }

                if (string.IsNullOrEmpty(model.Estado))
                {
                    model.Estado = "";
                }


                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "nombres", ClaimValue = model.Nombres });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "rut", ClaimValue = model.Rut });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "apellido_paterno", ClaimValue = model.ApellidoPaterno });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "apellido_materno", ClaimValue = model.ApellidoMaterno });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "telefono", ClaimValue = model.Telefono });                
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "direccion", ClaimValue = model.Direccion });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "cargo", ClaimValue = model.Cargo });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "celular", ClaimValue = model.Celular });
                this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "ProximaRenovacionPassword", ClaimValue = model.ProximaRenovacionPassword });
                
                if (!string.IsNullOrEmpty(model.Estado))
                {
                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "estado", ClaimValue = model.Estado });
                }
                this.Context.Command(new Domain.Command.AspNetUsers.EditEstados.Command() { Id = model.UserId, LockoutEnabled = model.Activo });


                if (model.Firma == "Borrar")
                {
                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "firma", ClaimValue = "" });
                }
                if (model.Contrato == "Borrar")
                {
                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "contrato", ClaimValue = "" });
                }
                if (model.Foto == "Borrar")
                {
                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "foto", ClaimValue = "" });
                }
                
                if (!string.IsNullOrEmpty(model.FechaCumpleanos))
                {
                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "fecha_Cumpleanos", ClaimValue = model.FechaCumpleanos });

                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "dia_cumpleanos", ClaimValue = model.FechaCumpleanos.Substring(0,5) });
                }



                //get all claims
                var claim = this.Context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = model.UserId });
                //default notificación by rol

                if (!claim.Any(c => c.ClaimType == "SetNotificación"))
                {
                    //var listcheck = this.Context.Query(new Domain.Query.UsuarioTipoNotificacion.Index.GetAllByRol.Query() { UserId = model.UserId });

                    ////delete notificaciones
                    //Context.Command(new Domain.Command.UsuarioTipoNotificacion.DeletebyUser.Command() { UserId = model.UserId });

                    ////create new id
                    //foreach (var item in listcheck.Items)
                    //{
                    //    var command = new Domain.Command.UsuarioTipoNotificacion.Create.Command
                    //    {
                    //        UserId = model.UserId,
                    //        TipoNotificacionId = (int)item,
                    //        UltimaModificacion = DateTime.Now,
                    //        UsuarioModificacion = this.User.UserId.ToString(),

                    //    };

                    //    Context.Command(command);


                    //}

                    this.Context.Command(new Domain.Command.AspNetUserClaims.EditByUserTypeValue.Command() { UserId = model.UserId, ClaimType = "SetNotificación", ClaimValue = DateTime.Now.ToString() });
                }

                return new JsonResult(model);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Error = ex.Message  });
            }  

            
        }
    }
}
