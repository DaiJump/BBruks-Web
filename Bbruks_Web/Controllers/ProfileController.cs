using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbruks_Web.Controllers
{
    public class ProfileController : Controller
    {
        // GET: PerfilController
        public ActionResult Perfil()
        {
            return View();
        }

        
    }
}
