﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.UI
{
    public class UiTypography : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ui-typography")]
        public ActionResult uitypography()
        {
            return View();
        }
    }
}
