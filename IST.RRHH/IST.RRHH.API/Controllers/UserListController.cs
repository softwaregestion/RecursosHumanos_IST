using System;
using System.Collections.Generic;
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
    [Route("api/userlist")]
    [AllowAnonymous]
    public class UserListController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public UserListController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            var model = this.Context.Query(new Domain.Query.AspNetUsers.Index.GetAll.Query()).Select(c => new UserIndexModel()
            {
                Email = c.Email,
                UserId = c.Id,
                UserName = c.UserName,
                Activo = c.LockoutEnabled                
            }).ToList();
            
            foreach (var item in model)
            {
                var claim = this.Context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = item.UserId });

                item.Nombres = $"{ReglasHelpers.GetClaimValue(claim, "nombres")} {ReglasHelpers.GetClaimValue(claim, "apellido_paterno")} {ReglasHelpers.GetClaimValue(claim, "apellido_materno")}";
                item.Rol  = ReglasHelpers.GetClaimValue(claim, "app_role.Contratista");
                item.Rut = ReglasHelpers.GetClaimValue(claim, "rut");                
                item.Fecha = ReglasHelpers.GetClaimValue(claim, "fecha_Creacion");              
                item.Estado = ReglasHelpers.GetClaimValue(claim, "estado");                
            }

            return new JsonResult(model);
        }



       
    }
}
