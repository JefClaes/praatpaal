using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace PraatPaal
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = x => { return View["home.cshtml"]; };
            Get["/onsteam.html"] = x => { return View["onsteam.cshtml"]; };
            Get["/afspraakmaken.html"] = x => { return View["afspraakmaken.cshtml"]; };
            Get["/locatie.html"] = x => { return View["locatie.cshtml"]; };
        }
    }
}