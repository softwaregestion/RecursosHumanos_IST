
using System.Linq;
using IST.Api.Helpers;
using IST.Api.Helpers.App;
using IST.Api.Models;
using IST.RRHH;
using IST.RRHH.Domain.Jobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IST.Api.Controllers
{
    [Route("api/useradmin")]
    [Authorize]
    public class UserAdminController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public UserAdminController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        [HttpGet]
        public IActionResult Index(string id)
        {
            var solicitantes = this.Context.Query(new RRHH.Domain.Query.AspNetUserClaims.Index.GetAll.Query() {  });
            if (solicitantes.Count > 0)
            {
                var ids = new System.Collections.Generic.List<string>();
                if (id != null)
                {
                    ids = new System.Collections.Generic.List<string>() { id };
                }
                else
                {
                    ids = solicitantes.Select(c => c.UserId).ToList();
                }
 
                var model = this.Context.Query(new RRHH.Domain.Query.AspNetUsers.Index.GetAllByIds.Query() { Ids = ids }).Select(c => new UserIndexModel()
                {
                    Email = c.Email,
                    UserId = c.Id,
                    UserName = c.UserName,
                    Activo = c.LockoutEnabled
                }).ToList();

                foreach (var item in model)
                {
                    var claim = this.Context.Query(new RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = item.UserId });

                    item.Nombres = $"{ReglasHelpers.GetClaimValue(claim, "nombres")} {ReglasHelpers.GetClaimValue(claim, "apellido_paterno")} {ReglasHelpers.GetClaimValue(claim, "apellido_materno")}";
                    item.Rol  = ReglasHelpers.GetClaimValue(claim, "app_role." + AppConfig.ClientId);
                    item.Fecha = ReglasHelpers.GetClaimValue(claim, "fecha_Creacion");
                    item.Rut = ReglasHelpers.GetClaimValue(claim, "rut");
                    item.Estado = ReglasHelpers.GetClaimValue(claim, "estado");
                   
                }

                model = model.OrderByDescending(c => c.Fecha).ToList();

                return Ok(model);
            }
            else {
                return Ok();
            }
        }

        //private static string GetClaimValue(List<Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Result> claim, string claimType)
        //{
        //    var claimR = claim.SingleOrDefault(c => c.ClaimType == claimType);
        //    if (claimR != null)
        //    {
        //        return claimR.ClaimValue;
        //    }
        //    return "";
        //}

       
    }
}
