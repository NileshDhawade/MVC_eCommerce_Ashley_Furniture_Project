using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_eCommerce_Ashley_Furniture_Project.Data;
using MVC_eCommerce_Ashley_Furniture_Project.Models;

namespace MVC_eCommerce_Ashley_Furniture_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View();
        }
    }
}
