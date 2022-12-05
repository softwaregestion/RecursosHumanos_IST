using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IST.Api.Models;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IST.Api.Controllers
{
    public class GetTokenController : Controller
    {

        private List<Claims> getClaims()
        {
            var claims = (from c in User.Claims select new Claims { Type = c.Type, Value = c.Value }).ToList();
            return claims;
        }

        private User GetUserInfoAsync()
        {
            if (!Request.Headers.Any(c => c.Key == "Authorization"))
            {
                return null;
            }

            var accessToken = Request.Headers.FirstOrDefault(c => c.Key == "Authorization").Value.ToString().Replace("Bearer ", "");

            using (var client = new HttpClient())
            {
                var userInfoResponse = client.GetUserInfoAsync(new UserInfoRequest
                {
                    Address = AppConfig.UrlSSO + "/connect/userinfo",
                    Token = accessToken
                });

                if (userInfoResponse.Result.IsError)
                    throw new Exception(userInfoResponse.Result.Error);

                var user = JsonConvert.DeserializeObject<User>(userInfoResponse.Result.Raw.ToString());

                user.Claims = getClaims();

                return user;
            }
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
