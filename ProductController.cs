using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

public class ProductController : Controller
{ 
    public ActionResult Index()
    {
        // Створення декількох прикладів продуктів (тестові дані)
        var products = new List<Product>
        {
            new Product { ID = 1, Name = "Forza Horizon", Price = 60.99m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Gears Of War 5", Price = 35.50m, CreatedDate = DateTime.Now.AddDays(-1) },
            new Product { ID = 3, Name = "Alan Wake", Price = 15.79m, CreatedDate = DateTime.Now.AddDays(-2) }
        };

        return View(products);
    }
}
