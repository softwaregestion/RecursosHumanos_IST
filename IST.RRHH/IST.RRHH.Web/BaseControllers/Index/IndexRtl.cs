using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Index
{
    public class IndexRtl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
