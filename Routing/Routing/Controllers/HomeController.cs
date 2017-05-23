using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            var result = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { Controller = "TestController", Action = "TestAction", id = 555, parametr = "Tomek" }));
            string s = result.VirtualPath;

            return s;
        }
    }
}