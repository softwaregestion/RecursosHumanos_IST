﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.Blog
{
    public class BlogDetails : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
