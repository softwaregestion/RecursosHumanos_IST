using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Projects
{
    public class ProjectsList : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("projects-list")]
        public ActionResult projectslist()
        {
            return View();
        }
    }
}
