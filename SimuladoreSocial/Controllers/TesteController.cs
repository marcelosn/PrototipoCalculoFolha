using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimuladoreSocial.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RetornaErro()
        {
           
            var a = 1;

            try
            {
              var b = a / 0;
                return Json(b);
            }
            catch
            {
                return Json("Numero não divisivel por 0");
            }
            
        }
    }
}
