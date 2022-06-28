using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Security1.Models;

namespace Security1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult SecurityDetails()
        {
            return View();
        }
    }
}