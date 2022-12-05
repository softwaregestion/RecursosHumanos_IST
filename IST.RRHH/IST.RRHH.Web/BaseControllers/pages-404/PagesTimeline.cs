using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.pages_404
{
    public class PagesTimeline : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("pages-timeline")]
        public ActionResult pagestimeline()
        {
            return View();
        }
    }
}
