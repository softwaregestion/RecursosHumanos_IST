using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System.Collections.Generic;
using IdentityModel.Client;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using IST.Api.Models;
using System.Threading.Tasks;

namespace IST.Api.Models
{
    public class Auth {

        public string Usuario { get; set; }

        public string Contrasena { get; set; }
    }
}

    namespace IST.Api.Controllers
{
    [Route("api/GetExternalToken")]
    [AllowAnonymous]
    public class GetExternalTokenController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Auth model)
        {

            if (model.Usuario == "SapExterno" && model.Contrasena == "Emsesa.2020")
            {
                var client = new HttpClient();

                var disco = await client.GetDiscoveryDocumentAsync(new DiscoveryDocumentRequest
                {
                    Address = AppConfig.UrlSSO,
                    Policy =  {RequireHttps = AppConfig.RequireHttpsMetadata}
                });


                if (disco.IsError)
                {
                    Console.WriteLine(disco.Error);
                    return BadRequest();
                }

                // request token
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = disco.TokenEndpoint,
                    ClientId = "api_emsesa",
                    ClientSecret = "Lmil2JopJBz-GH5tDioogcog",
                    Scope = "api1 openid email profile",
                    UserName = "admin",
                    Password = "Soyadmin20200"
                }); 

                if (tokenResponse.IsError)
                {
                    Console.WriteLine(tokenResponse.Error);
                    return BadRequest();
                }
                else
                {
                    return Ok( new { token = tokenResponse.AccessToken });
                }

            }
            else
            {
                return BadRequest();
            }
        }
    }
}
