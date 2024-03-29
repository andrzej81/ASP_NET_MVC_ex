﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            // Add action logic here
            throw new NotImplementedException();
        }

        public ActionResult Details(int Id)
        {
            if (Id < 1)
                return RedirectToAction("Index");

            var product = new Product(Id, "Laptop");
            return View("Details", product);
        }
    }
}
