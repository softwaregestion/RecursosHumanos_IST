﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Charts
{
    public class ChartsKnob : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("charts-knob")]
        public ActionResult chartsknob()
        {
            return View();
        }
    }
}
