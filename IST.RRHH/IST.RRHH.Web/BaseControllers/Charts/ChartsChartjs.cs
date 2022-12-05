using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Charts
{
    public class ChartsChartjs : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("charts-chartjs")]
        public ActionResult chartschartjs()
        {
            return View();
        }
    }
}
