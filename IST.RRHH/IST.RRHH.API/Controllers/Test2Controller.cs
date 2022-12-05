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
    [Route("api/test2")]
    [AllowAnonymous]
    public class Test2Controller : ControllerBase
    {
        IMediator Context;
        ICustomUserContext User;
        public Test2Controller(IMediator context, ICustomUserContext user)
        {

            this.Context = context;
            this.User = user;
        }

        public IActionResult Get()
        {   
            //var u = getClaims();
            string[] roles = new string[] { "Usuario" };
            try
            {
                var query = this.Context.Query(new Domain.Query.AspNetRoles.Index.GetAll.Query());
                return new JsonResult(query);
            }
            catch (Exception ex)
            {

                return new JsonResult(ex);
            }
            //var userInfoResponse = client.GetUserInfoAsync(new UserInfoRequest
            //{
            //    Address = AppConfig.UrlSSO + "/connect/userinfo",
            //    Token = accessToken
            //});


            //using (var client = new HttpClient())
            //{
            //    var userInfoResponse = client.GetUserInfoAsync(new UserInfoRequest
            //    {
            //        Address = AppConfig.UrlSSO + "/connect/userinfo",
            //        Token = 
            //    });

            //    if (userInfoResponse.Result.IsError)
            //        throw new Exception(userInfoResponse.Result.Error);

            //    var user = JsonConvert.DeserializeObject<User>(userInfoResponse.Result.Raw.ToString());
            //    if (user != null)
            //    {
            //        AccessToken = accessToken;
            //        SubjectId = user.sub;
            //        Name = user.name;
            //        Email = user.email;
            //        UserId = user.sub;
            //    }
            //}


            ////}
           
            

        }

    }
}
