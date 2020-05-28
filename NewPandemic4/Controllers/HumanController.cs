using Microsoft.AspNetCore.Mvc;
using NewPandemic4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * В HumanController добавьте action Country(если он у вас уже есть с занятия, переделайте согласно этому заданию). 
Action Country должен принимать один параметр - name(это название страны). 
Сделайте так чтоб в виде таблицы выводились все человеки из страны, имя которой было передано в action.
 */
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
           ViewData["human"] = _context.Humans.SingleOrDefault(human => human.Id == id);
            return View();
        }
        public IActionResult Country(string name)
        {
            ViewData["human"] = _context.Humans.ToList();
            return View();
        }
    }
}
