﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.UI
{
    public class UiProgressbars : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ui-progressbars")]
        public ActionResult uiprogressbars()
        {
            return View();
        }
    }
}
