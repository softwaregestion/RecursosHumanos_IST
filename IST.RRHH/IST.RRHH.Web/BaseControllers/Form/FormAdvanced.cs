﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Form
{
    public class FormAdvanced : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("form-advanced")]
        public ActionResult formadvanced()
        {
            return View();
        }
    }
}
