 
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
    [Route("api/clientadmin")]
    [Authorize]
    public class ClientAdminController : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        IEmailJobs Email;
        public ClientAdminController(IMediator context, ICustomUserContext user, IEmailJobs Email)
        {

            this.Context = context;
            this.User = user;
            this.Email = Email;
        }

        [HttpGet]
        public IActionResult Index(int? id)
        {
            
                var ids = new System.Collections.Generic.List<int>();
                if (id != null)
                {
                    ids = new System.Collections.Generic.List<int>() { id.Value };
                }

                var model = this.Context.Query(new RRHH.Domain.Query.Clients.Index.GetAllbyIds.Query() { Ids = ids }).Select(c => new ClientDataModel()
                {
                   ClientId = c.Id.ToString(),
                   Nombre = c.ClientName
                }).ToList();

                foreach (var item in model)
                {
                    var claim = this.Context.Query(new RRHH.Domain.Query.ClientClaims.Index.GetAllByClientId.Query() { ClientId = int.Parse(item.ClientId) });

                    item.ListadoClaims = claim;
                }
                 

                return Ok(model);
            
        }

       
       
    }
}
