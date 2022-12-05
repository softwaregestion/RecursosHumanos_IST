using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IST.RRHH.Domain.Jobs;

namespace IST.Api.Controllers
{
    [Route("api/up")]
    [AllowAnonymous]
    public class UpController : ControllerBase
    {
        IEmailJobs EmailJobs;
        public UpController(IEmailJobs emailJobs) {
            EmailJobs = emailJobs;
        }
        public  IActionResult Get()
        {   
           


            return new JsonResult(new {msj="up" });

        }

    }
}
