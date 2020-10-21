﻿using SUS.HTTP;
using SUS.MvcFramework;

namespace BattleCards.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse IndexSlash()
        {
            return this.Index();
        }

        public HttpResponse Index()
        {
            if (!this.IsUserSignedIn())
            {
                return this.View();
            }

            return this.Redirect("/Cards/All");
        }
    }
}
