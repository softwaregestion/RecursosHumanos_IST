﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Tables
{
    public class TablesBasic : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("tables-basic")]
        public ActionResult tablesbasic()
        {
            return View();
        }
    }
}
