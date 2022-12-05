using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Icon
{
    public class IconsMaterialDesign : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("icons-materialdesign")]
        public ActionResult iconsmaterialdesign()
        {
            return View();
        }
    }
}
