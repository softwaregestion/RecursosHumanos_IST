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
    [Route("api/claims")]
    [Authorize]
    public class ClaimsController : ControllerBase
    {
        IMediator context;
        ICustomUserContext user;
        public ClaimsController(IMediator context, ICustomUserContext user)
        {
            this.user = user;
            this.context = context;
        }

        public IActionResult Get()
        {
            try
            {
                var data = this.user;

                var claims = this.context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = data.UserId.ToString() });

                return new JsonResult(claims);
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }
    }
}
