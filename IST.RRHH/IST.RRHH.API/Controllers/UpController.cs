using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System.Collections.Generic;
using IdentityModel.Client;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using IST.RRHH.API.Models;
using IST.RRHH.Domain;
using IST.RRHH.Domain.Jobs;

namespace IST.RRHH.API.Controllers
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
