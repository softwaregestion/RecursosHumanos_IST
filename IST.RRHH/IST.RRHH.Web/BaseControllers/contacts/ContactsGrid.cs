﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IST.RRHH.Web.contacts
{
    public class ContactsGrid : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("contacts-grid")]
        public ActionResult contactsgrid()
        {
            return View();
        }
    }
}
