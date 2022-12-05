using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IST.RRHH.Web.UI
{
    public class UiOffCanvas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("ui-offcanvas")]
        public ActionResult uioffcanvas()
        {
            return View();
        }
    }
}
