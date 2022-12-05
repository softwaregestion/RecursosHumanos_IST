using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IST.RRHH.API.Helpers;
using IST.RRHH.API.Models;
using IST.RRHH.Domain.Jobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH.Domain;

namespace IST.RRHH.API.Controllers
{
    [Route("api/usermobile")]
    [Authorize]
    public class UserMobileController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext Userc;
        IEmailJobs Email;
        public UserMobileController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.Userc = user;
            this.Email = Email;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string id = this.Userc.UserId.ToString();

            return RedirectToAction("Get", "User", new { id = id });
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
