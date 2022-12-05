using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IST.RRHH.Domain;
using System.Collections.Generic;
using IdentityModel.Client;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using IST.RRHH.API.Models;
using IST.RRHH.API.Helpers;



namespace IST.RRHH.API.Controllers
{
    [Route("api/UserOff")]
    [AllowAnonymous]
    public class UserOffController : ControllerBase
    {
        IMediator context;
        public UserOffController(IMediator context)
        {
            this.context = context;
        }

        public IActionResult Get(string id)
        {
           

            var user = this.context.Query(new Domain.Query.AspNetUsers.Details.GetSingleItemByUserName.Query() { Username = id });
            if (user == null)
            {
                return new JsonResult(new { Mensaje = "El mail ingresado no se encuentra registrado" });
            }
            else
            {
                if (user.LockoutEnabled == true)
                {
                    var userc = this.context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = user.Id });
                    if (userc.Any(c => c.UserId == user.Id && c.ClaimType == "estado" && c.ClaimValue == "Solicitado"))
                    {
                        return new JsonResult(new { Mensaje = "Usuario registrado, está en espera de autorización por el Administrador de la aplicación." });
                    }
                }
                else
                {
                    var userc = this.context.Query(new Domain.Query.AspNetUserClaims.Index.GetAllByUserId.Query() { UserId = user.Id });
                    if (userc.Any(c => c.UserId == user.Id && c.ClaimType == "estado" && c.ClaimValue == "Solicitado"))
                    {
                        return new JsonResult(new { Mensaje = "Usuario registrado, está en espera de autorización por el Administrador de la aplicación." });
                    }
                    else
                    {
                        return new JsonResult(new { Mensaje = "La cuenta se encuentra no activa, contacte con el Administrador de sistema para consultar por su acceso." });
                    }
                }
            }

            

            return new JsonResult(new { Mensaje = "Usuario o contraseña incorrecto." });
        }

       
    }
}
