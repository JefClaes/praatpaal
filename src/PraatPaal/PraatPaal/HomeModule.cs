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
        }
    }
}