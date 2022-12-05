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
    [Route("api/roles")]
    [Authorize]
    public class RolesController : ControllerBase
    {
        IMediator context;
        ICustomUserContext user;
        public RolesController(IMediator context, ICustomUserContext user)
        {
            this.user = user;
            this.context = context;
        }

        public IActionResult Get()
        {
            try
            {
                var data = this.user;

                List<string> roles = new List<string>();

                var claims = this.context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = data.UserId.ToString() });
                if (claims != null)
                {
                    var rol = claims.FirstOrDefault(c => c.ClaimType == "app_role.Contratista");
                    if (rol != null)
                    {
                        roles.Add(rol.ClaimValue);
                    }
                }

                if (roles.Count == 0)
                {
                    roles.Add("Usuario");
                }

                return new JsonResult(roles);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}
