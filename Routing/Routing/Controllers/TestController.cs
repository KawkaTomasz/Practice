using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    [RoutePrefix("Test")]
    public class TestController : Controller
    {
        [Route("atribute/parametr/path")]
        public string Index()
        {
            return "Test atrybutow";
        }

        [Route("{parametr:int}")]
        public string Test(int parametr)
        {
            return "Metoda test - parametr: " + parametr;
        }
    }
}