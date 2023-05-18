using IST.Api.Helpers;
using IST.RRHH;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IST.Api.Controllers
{
    [Route("api/wsp")]
    [AllowAnonymous]
    public class WspController : Controller
    {
        IMediator Context;
        ICustomUserContext User;
        public WspController(IMediator context, ICustomUserContext user)
        {

            this.Context = context;
            this.User = user;
        }

        //[HttpPost]
        public async Task<IActionResult> Get(string fono, string usr, string code)
        {
            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "EAAQZAd4Tqyl0BAIFkCZBXttsMSeLmntwlc03mPNiJOYj7M7aapIrYuN2hDdNptJtwVWpmxNlF3DoJh6xWVt9xsMBkCzho1XvJODXdNaAcVO3ZBt0UMSa9dco8NxQDlnwZC8NLrSk3fmTApxDsihUhSLaEGiNsWxohF1CaX3GB1bbDmURkbbdrzrxAABJyZBc3VPRhzTWNEQZDZD");
                // var stringPayload = JsonConvert.SerializeObject(payload);
                // Console.WriteLine(stringPayload);C:\inetpub\wwwroot\rrhhapi\Web\App_Data\TemplateWsp
                //var stringPayload = System.IO.File.ReadAllText(@"~/App_Data/TemplateWsp/template.json");
                var stringPayload = System.IO.File.ReadAllText(@"C:\inetpub\wwwroot\rrhhapi\Web\App_Data\TemplateWsp\template.json");

                //var PhoneNumber = View.GetInputString("Indique el numero al que quiere enviar el mensaje");
                stringPayload = stringPayload.Replace("PHONENUMBER", fono);
                stringPayload = stringPayload.Replace("VARIABLE0", usr);
                stringPayload = stringPayload.Replace("VARIABLE1", code);

                //Console.WriteLine(stringPayload);
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("https://graph.facebook.com/v15.0/115113608195207/messages", httpContent);
                var responseString = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(responseString);

                var respuesta = response.ReasonPhrase == "OK" ? "OK" : "NULL";

                string[] roles = new string[] { respuesta };

                return new JsonResult(roles);
            }
            catch (System.Exception)
            {
                string[] roles = new string[] { "NULL" };

                return new JsonResult(roles);
            }
            
        }
    }
}
