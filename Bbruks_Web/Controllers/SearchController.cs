using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbruks_Web.Controllers
{
    public class SearchController : Controller
    {
        // GET: SearchController
        public ActionResult Search()
        {
            return View();
        }

       
    }
}
