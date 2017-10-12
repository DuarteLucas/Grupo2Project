﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginWithAuthenticationTest.Controllers
{
    public class SearchOffersController : Controller
    {
        // GET: SearchOffers
        [Authorize(Roles = "Admin,Company,Programmer")]
        public ActionResult SearchOffers()
        {
            return View();
        }
    }
}