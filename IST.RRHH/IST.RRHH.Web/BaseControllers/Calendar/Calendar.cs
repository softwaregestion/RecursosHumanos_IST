﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Calendar
{
    public class Calendar : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
