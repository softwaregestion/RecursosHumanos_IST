using IST.Api.Models;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace IST.Api.Helpers
{



    public class UserContext :  ICustomUserContext
    {  

        public UserContext(IHttpContextAccessor httpContext)
        {
            if (httpContext.HttpContext.Request.Headers.Any(c => c.Key == "Authorization"))
            {
                var accessToken = httpContext.HttpContext.Request.Headers.FirstOrDefault(c => c.Key == "Authorization").Value.ToString().Replace("Bearer ", "");
                using (var client = new HttpClient())
                {
                    var userInfoResponse = client.GetUserInfoAsync(new UserInfoRequest
                    {
                        Address = AppConfig.UrlSSO + "/connect/userinfo",
                        Token = accessToken
                    });

                    if (userInfoResponse.Result.IsError)
                    {
                        //httpContext.HttpContext.Response.Redirect("/~");

                        httpContext.HttpContext.Response.Redirect("/account/login");
                        return;
                        //throw new Exception(userInfoResponse.Result.Error);
                    }


                    var user = JsonConvert.DeserializeObject<User>(userInfoResponse.Result.Raw.ToString());
                    if (user != null)
                    {
                        AccessToken = accessToken;
                        SubjectId = user.sub;
                        Name = user.name;
                        Email = user.email;
                        UserId = user.sub;
                    }               
                }
            }
        }

        public string UserLogin { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }
        public Guid UserId { get; set; }
        public Guid SubjectId { get; set; }
        public string[] Roles { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAdmin { get; set; }

        public string UserRole { get; set; }

        public string PointSeparatedName { get; set; }

    }


    public interface ICustomUserContext
    {
        bool IsAdmin
        {
            get;
        }

        bool IsAuthenticated
        {
            get;
        }

        string Name
        {
            get;
        }

        string[] Roles
        {
            get;
        }

        Guid SubjectId
        {
            get;
        }

        Guid UserId
        {
            get;
        }

        string UserLogin
        {
            get;
        }
        string AccessToken
        {
            get;
        }

    }
}