using Client.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Ticket()
        {
            return View();
        }

        public IActionResult Junior()
        {
            return View();
        }

        public IActionResult Helpdesk()
        {
            return View();
        }

        public IActionResult Engineer()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public async Task<JsonResult> GetRegistrasiView()
        //{
        //    var result = await repository.GetRegistrasiView();
        //    return Json(result);
        //}
    }
}
    


