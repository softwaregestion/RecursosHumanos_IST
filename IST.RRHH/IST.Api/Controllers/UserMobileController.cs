using IST.Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IST.RRHH;
using IST.RRHH.Domain.Jobs;

namespace IST.Api.Controllers
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
