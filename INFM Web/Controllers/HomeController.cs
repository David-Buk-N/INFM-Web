using INFM_Web.Models;
using INFM_Web.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace INFM_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;
        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public async Task<IActionResult> Shop(string sterm="", int categoryId=0)
        {
            IEnumerable<Product> products = await _homeRepository.DisplayProducts(sterm, categoryId);
            IEnumerable<Category> categories = await _homeRepository.Categories();
            ProductDisplayModel productModel = new ProductDisplayModel
            {
                products = products,
                categories = categories,
                STerm = sterm,
                CategoryId = categoryId
            };

            return View(productModel);
        }
        public IActionResult Dash()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}