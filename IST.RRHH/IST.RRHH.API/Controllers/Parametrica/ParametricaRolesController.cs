﻿using System.Linq;
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
    [Route("api/parametricaroles")]
    [Authorize]
    public class ParametricaRolesController : ControllerBase
    {
        IMediator context;
        ICustomUserContext user;
        public ParametricaRolesController(IMediator context, ICustomUserContext user)
        {
            this.user = user;
            this.context = context;
        }

        public IActionResult Get()
        {
            var data = this.user;

            var obj = this.context.Query(new IST.RRHH.Domain.Query.AspNetRoles.Index.GetAll.Query());

            return new JsonResult(obj.Select(c => new Parametrica { Text = $"{c.NormalizedName}" , Value = c.Id.ToString() }).OrderBy(c=>c.Text).ToList());
        }
    }
}
