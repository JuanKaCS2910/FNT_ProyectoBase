using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FNT_ProyectoBase.Controllers
{
    public class LayoutsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OffCanvas()
        {
            return View();
        }
    }
}