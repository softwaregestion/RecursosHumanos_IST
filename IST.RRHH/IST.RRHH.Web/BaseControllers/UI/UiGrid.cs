﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.UI
{
    public class UiGrid : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ui-grid")]
        public ActionResult uigrid()
        {
            return View();
        }
    }
}
