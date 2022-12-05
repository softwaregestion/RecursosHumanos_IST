using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Tables
{
    public class TablesDatatable : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("tables-datatable")]
        public ActionResult tablesdatatable()
        {
            return View();
        }
    }
}
