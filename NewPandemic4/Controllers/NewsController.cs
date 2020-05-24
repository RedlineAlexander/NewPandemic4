using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewPandemic4.Models;
using NewPandemic4.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewPandemic4.Controllers
{
    public class NewsController : Controller
    {

      //  private readonly ILogger<NewsController> _logger;
      private INewsRepositories _repository { get; set; }

        public NewsController(INewsRepositories repositories)
        {
            _repository = repositories;
        }


        public IActionResult Index() {



            ViewData["key"] = _repository.GetAllNews();
            return View();
        }
        public IActionResult Show(int newsId)
        {
            ViewData["key"] = _repository.GetAllNews();
            return View();
        }
        public IActionResult Privacy()
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
