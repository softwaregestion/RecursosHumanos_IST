using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Charts
{
    public class ChartsFlot : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("charts-flot")]
        public ActionResult chartsflot()
        {
            return View();
        }
    }
}
