﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.Maps
{
    public class MapsLeaflet : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("maps-leaflet")]
        public ActionResult mapsleaflet()
        {
            return View();
        }
    }
}
