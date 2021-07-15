﻿using API52.Models;
using API52.ViewModel;
using Client.Base;
using Client.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginRepository repository;
        public LoginController(LoginRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult j()
        {
            return View();
        }

        public IActionResult h()
        {
            return View();
        }

        public IActionResult e()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Auth(LoginVM login)
        {
            var jwtoken = await repository.Auth(login);
            if(jwtoken == null)
            {
                return RedirectToAction("index");
            }
            HttpContext.Session.SetString("JWToken", jwtoken.Token);
            return RedirectToAction("dashboard", "admin");
        }

        [HttpPost]
        public async Task<IActionResult> Authj(LoginVM login)
        {
            var jwtoken = await repository.Auth(login);
            if (jwtoken == null)
            {
                return RedirectToAction("index");
            }
            HttpContext.Session.SetString("JWToken", jwtoken.Token);
            return RedirectToAction("junior", "admin");
        }

        [HttpPost]
        public async Task<IActionResult> Authh(LoginVM login)
        {
            var jwtoken = await repository.Auth(login);
            if (jwtoken == null)
            {
                return RedirectToAction("index");
            }
            HttpContext.Session.SetString("JWToken", jwtoken.Token);
            return RedirectToAction("helpdesk", "admin");
        }

        [HttpPost]
        public async Task<IActionResult> Authe(LoginVM login)
        {
            var jwtoken = await repository.Auth(login);
            if (jwtoken == null)
            {
                return RedirectToAction("index");
            }
            HttpContext.Session.SetString("JWToken", jwtoken.Token);
            return RedirectToAction("engineer", "admin");
        }
    }
}
