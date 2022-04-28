using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVC_eCommerce_Ashley_Furniture_Project.Data;
using MVC_eCommerce_Ashley_Furniture_Project.Models;
using System;
using System.Linq;

namespace MVC_eCommerce_Ashley_Furniture_Project.Controllers
{
    public class UsersController : Controller
    {

        private readonly ApplicationDbContext context;

        public UsersController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]

        public IActionResult LogIn(Users user)
        {
            var us = context.Users.Where(u => u.Email == user.Email && u.Password == user.Password).SingleOrDefault();
            if (us != null)
            {
                if (us.RoleId == 1)
                {
                    //ViewBag.popmessage = "<script> alert('LogIn Successfull!') </script>"; 
                    HttpContext.Session.SetInt32("UserId", us.UserId);
                    return RedirectToAction("Index", "Customer");
                }
                else
                {
                    ViewBag.popmessage = "<script> alert('LogIn Successfull!') </script>";
                    return RedirectToAction("AllProductList", "Inventry");
                    //return View();
                }
            }
            else
            {
                ViewBag.popmessage = "<script> alert('LogIn Failed!') </script>";
                ModelState.Clear();
                return View();
            }

        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Users users)
        {
            try
            {
                users.RoleId = 1;
                context.Add(users);
                int result = context.SaveChanges();
                if (result == 1)
                {
                    ViewBag.Message = "<script> alert('SignUp Successfull!') </script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Message = "<script> alert('SignUp Failed Please try again!') </script>";
                    ModelState.Clear();
                }

            }
            catch (Exception ex) { }
            return View();
        }
    }
}
