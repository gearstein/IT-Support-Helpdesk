using API52.Models;
using API52.ViewModel;
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

        // Employee
        public IActionResult Actual()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }

        // Junior
        public IActionResult ActualJ()
        {
            return View();
        }
        public IActionResult HistoryJ()
        {
            return View();
        }
        public IActionResult Master()
        {
            return View();
        }

        // Helpdesk
        public IActionResult ActualH()
        {
            return View();
        }
        public IActionResult HistoryH()
        {
            return View();
        }
        public IActionResult MasterH()
        {
            return View();
        }

        // Engineer
        public IActionResult ActualE()
        {
            return View();
        }

        public IActionResult HistoryE()
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

        public async Task<JsonResult> FindRequest()
        {
            //var jwtnik = repository.JwtNIK();
            var nik = HttpContext.Session.GetString("NIK");
            var result = await repository.FindRequest(nik);
            return Json(result);
        }

        public async Task<JsonResult> FindComplete()
        {
            //var jwtnik = repository.JwtNIK();
            var nik = HttpContext.Session.GetString("NIK");
            var result = await repository.FindComplete(nik);
            return Json(result);
        }

        public async Task<string> showToken()
        {
            var token = await repository.getJWT();
            return token;
        }
        public IActionResult RegisterH()
        {
            return View();
        }
        // Chart
        public async Task<JsonResult> FindChart()
        {
            //var jwtnik = repository.JwtNIK();
            var nik = HttpContext.Session.GetString("NIK");
            var result = await repository.FindChart(nik);
            return Json(result);
        }
    }
}
    


