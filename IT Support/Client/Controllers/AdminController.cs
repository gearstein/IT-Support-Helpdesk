using API52.Models;
using Client.Base;
using Client.Models;
using Client.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class AdminController : BaseController<TicketRequest, TicketRequestRepository, int>
    {
        private readonly TicketRequestRepository repository;
        public AdminController(TicketRequestRepository repository) : base(repository)
        {
            this.repository = repository;
        }


        //[HttpPut("Home/Put")]
        //public JsonResult Put(Coba entity)
        //{
        //    var result = TicketRequestRepository.Put(entity);

        //    HttpContext.Session.SetString("Name", entity.FirstName);
        //    return Json(result);
        //}

        //[Authorize(Roles = "employee, junior, helpdesk, engineer")]

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Actual()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Master()
        {
            return View();
        }

        public IActionResult MasterH()
        {
            return View();
        }

        public IActionResult MasterE()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }

        //[Authorize(Roles = "junior")]
        public IActionResult Junior()
        {
            return View();
        }

        //[Authorize(Roles = "helpdesk")]
        public IActionResult Helpdesk()
        {
            return View();
        }

        //[Authorize(Roles = "engineer")]
        public IActionResult Engineer()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<JsonResult> GetRequestView()
        {
            var result = await repository.GetRequestView();
            return Json(result);
        }


    }
}
    


