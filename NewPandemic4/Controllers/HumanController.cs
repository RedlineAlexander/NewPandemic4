using Microsoft.AspNetCore.Mvc;
using NewPandemic4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPandemic4.Controllers
{
    public class HumanController : Controller
    {
        private InfestationContext _context { get; set; }


        public HumanController(InfestationContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
           ViewData["human"] = _context.Humans.SingleOrDefault(x => x.Id == id);
            return View();
        }
    }
}
