﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NwbaExample.Data;
using NwbaExample.Models;
using SimpleHashing;

namespace NwbaExample.Controllers
{
    [Route("/Nwba/SecureLogin")]
    public class LoginController : Controller
    {
        private readonly NwbaContext _context;

        public LoginController(NwbaContext context) => _context = context;

        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string loginID, string password)
        {
            var login = await _context.Logins.FindAsync(loginID);
            if(login == null || !PBKDF2.Verify(login.PasswordHash, password))
            { 
                ModelState.AddModelError("LoginFailed", "Login failed, please try again.");
                return View(new Login { LoginID = loginID });
            }

            // Login customer.
            HttpContext.Session.SetInt32(nameof(Customer.CustomerID), login.CustomerID);
            HttpContext.Session.SetString(nameof(Customer.Name), login.Customer.Name);

            return RedirectToAction("Index", "Customer");
        }

        [Route("LogoutNow")]
        public IActionResult Logout()
        {
            // Logout customer.
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
