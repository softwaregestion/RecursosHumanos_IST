﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Form
{
    public class FormUploads : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [ActionName("form-uploads")]
        public ActionResult formuploads()
        {
            return View();
        }
    }
}
