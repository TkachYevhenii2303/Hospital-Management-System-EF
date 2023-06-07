using AutoMapper;
using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.RegistrationModels;
using Hospital_Management_System_WEB.Models;
using Hospital_Management_System_WEB.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hospital_Management_System_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly HospitalManagementContext _context;

        public HomeController(HospitalManagementContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return LocalRedirect("/Index");
        }

        [Authorize]
        public IActionResult Employee() => LocalRedirect("/Employee/Employee");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
