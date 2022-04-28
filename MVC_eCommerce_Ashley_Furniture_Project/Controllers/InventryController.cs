using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_eCommerce_Ashley_Furniture_Project.Data;
using MVC_eCommerce_Ashley_Furniture_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_eCommerce_Ashley_Furniture_Project.Controllers
{
    public class InventryController : Controller
    {
        private readonly ApplicationDbContext context;

        public InventryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult AllProductList()
        {
            var prod = context.Inventry.ToList();
            var cat = context.Category.ToList();
            //  List<Product> products = new List<Product>();
            //  Product product = new Product();
            foreach (Inventry item in prod)
            {
                foreach (Category c in cat)
                {
                    if (c.CategoryId == item.CategoryId)
                    {
                        item.CategoryName = c.CategoryName;
                    }
                }
            }
            //  {

            //       product.ProductId = item.ProductId;
            //      product.ProductName = item.ProductName;
            //      product.CategoryName = cat.CategoryName;
            //      product.ProductPrice = item.ProductPrice;
            //      products.Add(product);
            //  }

            var products = context.Inventry.ToList();
            ViewBag.Products = products;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cat = context.Category.ToList();
            ViewBag.Category = new SelectList(cat, "CategoryId", "CategoryName");
            //ViewBag["Category"] = new SelectList(cat);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Inventry inventry)
        {
            context.Inventry.Add(inventry);
            int id = context.SaveChanges();
            if (id == 1)
            {
                ViewBag.Message = "< script > alert('Successfull Added!') </ script > ";
                return RedirectToAction("AllProductList", "Inventry");
            }
            else
            {
                ViewBag.Message = "< script > alert('Failed!') </ script >";
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int ProductId)
        {
            var prod = context.Inventry.Where(p => p.ProductId == ProductId).SingleOrDefault();
            var cat = context.Category.ToList();

            //  var cate = context.Category.Where(c => c.CategoryId == prod.CategoryId);
            ViewBag.Category = new SelectList(cat, "CategoryId", "CategoryName");
            return View(prod);
        }
        [HttpPost]
        public IActionResult Edit(Inventry inventry)
        {
            var prod = context.Inventry.Where(p => p.ProductId == inventry.ProductId).SingleOrDefault();
            if (prod != null)
            {
                prod.ProductName = inventry.ProductName;
                prod.ProductPrice = inventry.ProductPrice;
                prod.CategoryId = inventry.CategoryId;

                context.Update(prod);
                int res = context.SaveChanges();
                if (res == 1)
                {
                    ViewBag.UpdateMessage = "< script > alert('Updated!') </ script >";
                    return RedirectToAction("AllProductList", "Inventry");
                }
                else
                {
                    ViewBag.UpdateMessage = "< script > alert('Failed!') </ script >";
                    return RedirectToAction("AllProductList", "Inventry");
                }
            }
            else
            {
                ViewBag.UpdateMessage = "< script > alert('Not FOund!') </ script >";
                return RedirectToAction("AllProductList", "Inventry");
            }
        }

        [HttpGet]

        public IActionResult Delete(int ProductId)
        {
            var result = context.Inventry.Where(p => p.ProductId == ProductId).SingleOrDefault();

            return View(result);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int ProductId)
        {
            var prod = context.Inventry.Where(p => p.ProductId == ProductId).SingleOrDefault();
            if (prod != null)
            {
                context.Remove(prod);
                int res = context.SaveChanges();
                if (res == 1)
                {
                    ViewBag.DeleteMessage = "< script > alert('Deleted!') </ script >";
                    return RedirectToAction("AllProductList", "Inventry");
                }
                else
                {
                    ViewBag.DeleteMessage = "< script > alert('Failed!') </ script >";
                    return RedirectToAction("AllProductList", "Inventry");
                }

            }
            else
            {
                ViewBag.DeleteMessage = "< script > alert('Not Found!') </ script >";
                return RedirectToAction("AllProductList", "Inventry");
            }
        }

    }
}
