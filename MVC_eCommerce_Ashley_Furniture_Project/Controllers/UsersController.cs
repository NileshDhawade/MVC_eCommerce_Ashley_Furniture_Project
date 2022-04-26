using Microsoft.AspNetCore.Mvc;
using MVC_eCommerce_Ashley_Furniture_Project.Data;
using MVC_eCommerce_Ashley_Furniture_Project.Models;
using System;
using System.Linq;

namespace MVC_eCommerce_Ashley_Furniture_Project.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Users users)
        {
            try
            {
                users.RoleId = 1;
                _context.Add(users);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            
            return RedirectToAction("LogIn","Users");

        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(Users user)
        {
            var us = _context.Users.Where(u => u.UserEmailId == user.UserEmailId && u.UserPassword==user.UserPassword).SingleOrDefault();
            if (us != null)
            {
                if(us.RoleId == 1)
                {
                    return RedirectToAction("Index","Admin");
                }
                else if(us.RoleId == 2)
                {
                    return RedirectToAction("Index", "Users");
                }
            }
            return View();
        }
    }
}
