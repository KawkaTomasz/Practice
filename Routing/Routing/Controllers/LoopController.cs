using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class LoopController : Controller
    {
        // GET: Loop
        public string ForLoop(int id)
        {
            string result = "";
            for (int i = 0; i < id; i++)
            {
                result += "Hello World" + id + "<br/>";
            }
            return result;
        }
    }
}