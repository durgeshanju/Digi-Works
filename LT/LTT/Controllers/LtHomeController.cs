﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTT.Controllers
{
    public class LtHomeController : Controller
    {
        // GET: LtHome
        public ActionResult Index()
        {
            return View();
        }
    }
}