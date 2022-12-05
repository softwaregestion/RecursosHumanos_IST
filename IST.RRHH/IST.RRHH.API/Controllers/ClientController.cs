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
    [Route("api/client")]
    [AllowAnonymous]
    public class ClientController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public ClientController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        

        [HttpGet]
        public IActionResult Get(int id)
        {
            var userAsp = this.Context.Query(new Domain.Query.Clients.Details.GetSingleItem.Query() { Id = id });
            
            var claim = this.Context.Query(new Domain.Query.ClientClaims.Index.GetAllByClientId.Query() { ClientId = id });
            
            var model = new ClientDataModel();
            
            
            model.ClientId = userAsp.Id.ToString();
            model.Nombre = userAsp.ClientName;

            model.TimeOut = ReglasHelpers.GetClaimValue(claim, "TimeOut");
            model.Icono = ReglasHelpers.GetClaimValue(claim, "Icono");
            model.Descripcion = ReglasHelpers.GetClaimValue(claim, "Descripcion");

            if (model.TimeOut == "")
            {
                model.TimeOut = "9999";
            }

            model.ListadoClaims = claim;
            return new JsonResult(model);
        }

       

        [HttpPost]
        public IActionResult Post([FromBody]CrearClientModel model)
        { 
            try
            {  
                if (string.IsNullOrEmpty(model.TimeOut))
                {
                    model.TimeOut = "9999";
                }
                 
                this.Context.Command(new Domain.Command.ClientClaims.EditByClientTypeValue.Command() { ClientId = model.ClientId, ClaimType = "TimeOut", ClaimValue = model.TimeOut });
                this.Context.Command(new Domain.Command.ClientClaims.EditByClientTypeValue.Command() { ClientId = model.ClientId, ClaimType = "Icono", ClaimValue = model.Icono });
                this.Context.Command(new Domain.Command.ClientClaims.EditByClientTypeValue.Command() { ClientId = model.ClientId, ClaimType = "Descripcion", ClaimValue = model.Descripcion });

                return new JsonResult(model);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Error = ex.Message  });
            }  

            
        }
    }
}
