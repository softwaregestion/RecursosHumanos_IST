using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System.Collections.Generic;
using IdentityModel.Client;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using IST.RRHH.API.Models;
using IST.RRHH.API.Helpers;
using IST.RRHH.Domain;

namespace IST.RRHH.API.Controllers
{
    [Route("api/parametricausuario")]
    [Authorize]
    public class ParametricaUsuarioController : ControllerBase
    {
        IMediator context;
        ICustomUserContext user;
        public ParametricaUsuarioController(IMediator context, ICustomUserContext user)
        {
            this.user = user;
            this.context = context;
        }

        public IActionResult Get()
        {

            var model = this.context.Query(new IST.RRHH.Domain.Query.AspNetUsers.Index.GetAll.Query()).Select(c => new Parametrica()
            {   
                Value = c.Id
            }).ToList();

            if (model.Count > 0)
            {
                var users = model.Select(c => c.Value).ToList();

                var claims = this.context.Query(new IST.RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUsersId.Query() { UsersId = users });

                foreach (var item in model)
                {
                    var claim = claims.Where(c=> c.UserId == item.Value).ToList();
                    item.Text = $"{GetClaimValue(claim, "nombres")} {GetClaimValue(claim, "apellido_paterno")} {GetClaimValue(claim, "apellido_materno")}";
                    item.ParentId = GetClaimValue(claim, "rut");
                }

            }

            return new JsonResult(model);
        }

        private static string GetClaimValue(List<IST.RRHH.Domain.Query.AspNetUserClaims.Index.GetAllByUsersId.Result> claim, string claimType)
        {
            var claimR = claim.SingleOrDefault(c => c.ClaimType == claimType);
            if (claimR != null)
            {
                return claimR.ClaimValue;
            }
            return null;
        }
    }
}
