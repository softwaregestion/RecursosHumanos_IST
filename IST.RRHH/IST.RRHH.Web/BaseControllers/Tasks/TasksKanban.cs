using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Tasks
{
    public class TasksKanban : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("tasks-kanban")]
        public ActionResult taskskanban()
        {
            return View();
        }
    }
}
