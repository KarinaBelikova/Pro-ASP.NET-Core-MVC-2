using Microsoft.AspNetCore.Mvc;
using WorkingWith.Models;
using System.Linq;

namespace WorkingWith.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            => View(SimpleRepository.SharedRepository.Products.Where(p => p?.Price < 50));
    }
}
