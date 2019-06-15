using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            #region List
            //List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //}

            //return View(results);
            #endregion

            #region Dictionary
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] =  new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            //};

            //return View("Index", products.Keys);
            #endregion

            #region IS
            //object[] data = new object[] { 275M, 29.9M, "apple", "orange", 100, 10 };
            //decimal total = 0;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}

            //return View("Index", new string[] { $"Total: {total:C2}" });
            #endregion

            #region CASE
            //object[] data = new object[] { 275M, 29.9M, "apple", "orange", 100, 10 };
            //decimal total = 0;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}

            //return View("Index", new string[] { $"Total: {total:C2}" });
            #endregion

            #region Extension Method
            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            //decimal cartTotal = cart.TotalPrices();

            //return View("Index", new string[] { $"Total: {cartTotal:C2} "});
            #endregion

            #region Extension Method Interface
            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            //Product[] productArray =
            //{
            //    new Product { Name = "Kayak", Price = 275M },
            //    new Product { Name = "Lifejacket", Price = 48.95M },
            //    new Product { Name = "Soccer ball", Price = 19.50M },
            //    new Product { Name = "Corner flag", Price = 34.95M }
            //};           

            //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

            //return View("Index", new string[] 
            //{
            //    $"Price Total: {priceFilterTotal:C2}",
            //    $"Name Total: {nameFilterTotal:C2}"
            //});
            #endregion

            #region Lambda
            //return View(Product.GetProducts().Select(p => p?.Name));
            #endregion

            #region Var array
            //var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            //return View(names);
            #endregion

            #region Var Struct
            //var products = new[]
            //{
            //    new {Name ="Kayak", Price = 275M},
            //    new {Name ="Lifejacket", Price = 48.95M},
            //    new {Name ="Soccer ball", Price = 19.50M},
            //    new {Name ="Corner flag", Price = 34.95M}
            //};

            //return View(products.Select(p => p.GetType().Name));
            #endregion

            var products = new[]
            {
                new {Name ="Kayak", Price = 275M},
                new {Name ="Lifejacket", Price = 48.95M},
                new {Name ="Soccer ball", Price = 19.50M},
                new {Name ="Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

        #region async
        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}
        #endregion
    }
}
