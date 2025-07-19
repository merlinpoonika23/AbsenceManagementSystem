using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AbsenceManagementSystem.Models;
namespace AbsenceManagementSystem.Controllers
{
    
    public class AuthController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }


    }
}