﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Layouts
{
    public class LayoutsHoriScrollable : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
