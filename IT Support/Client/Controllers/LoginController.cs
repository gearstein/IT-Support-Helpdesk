using API52.Models;
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


        [HttpPost]
        public async Task<IActionResult> Auth(LoginVM login)
        {
            var jwtoken = await repository.Auth(login);
            if (jwtoken == null)
            {
                return RedirectToAction("index");
            }
            HttpContext.Session.SetString("JWToken", jwtoken.Token);
            HttpContext.Session.SetString("Email", repository.JwtEmail(jwtoken.Token));
            HttpContext.Session.SetString("role", repository.JwtRole(jwtoken.Token));
            HttpContext.Session.SetString("NIK", repository.JwtNIK(jwtoken.Token));

            var role = HttpContext.Session.GetString("role");
            if (role == "employee")
            {
                return RedirectToAction("dashboard", "admin");
            }
            else if (role == "junior")
            {
                return RedirectToAction("junior", "admin");
            }
            else if (role == "helpdesk")
            {
                return RedirectToAction("helpdesk", "admin");
            }
            else if (role == "engineer")
            {
                return RedirectToAction("engineer", "admin");
            }
            else
            {
                return RedirectToAction("index", "login");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index", "login");
        }
    }
}
