using API52.Models;
using Client.Base;
using Client.Models;
using Client.Repositories.Data;
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
    public class AdminController : BaseController<TicketRequest, TicketRequestRepository, int>
    {
        private readonly TicketRequestRepository repository;
        public AdminController(TicketRequestRepository repository) : base(repository)
        {
            this.repository = repository;
        }
<<<<<<< HEAD
        //[Authorize(Roles = "employee, junior, helpdesk, engineer")]
=======
        [Authorize(Roles = "Employee, Junior Helpdesk, Helpdesk, Engineer")]
>>>>>>> 3c167f7459d48f81490332c1cda7c62c614a1b16
        public IActionResult Dashboard()
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

<<<<<<< HEAD
        //[Authorize(Roles = "junior")]
=======
        [Authorize(Roles = "Junior Helpdesk")]
>>>>>>> 3c167f7459d48f81490332c1cda7c62c614a1b16
        public IActionResult Junior()
        {
            return View();
        }

<<<<<<< HEAD
        //[Authorize(Roles = "helpdesk")]
=======
        [Authorize(Roles = "Helpdesk")]
>>>>>>> 3c167f7459d48f81490332c1cda7c62c614a1b16
        public IActionResult Helpdesk()
        {
            return View();
        }

<<<<<<< HEAD
        //[Authorize(Roles = "engineer")]
=======
        [Authorize(Roles = "Engineer")]
>>>>>>> 3c167f7459d48f81490332c1cda7c62c614a1b16
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
    


