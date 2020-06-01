using Microsoft.AspNetCore.Mvc;
using NewPandemic4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*

    
В HumanController добавьте action Country(если он у вас уже есть с занятия, переделайте согласно этому заданию). 
Action Country должен принимать один параметр - name(это название страны). 
Сделайте так чтоб в виде таблицы выводились все человеки из страны, имя которой было передано в action.
Тут вам необходимо использовать Query параметр, а не Path(прочитайте первый пункт теории).

В Action Index контроллера HumanController добавьте возможность выводить всех человеков, если параметр id равен нулю,
в обратном случае выводить человека Id которого равен значению параметра id.
Переименуйте параметр id в humanId и передавайте его как Query параметр.
Создайте интерфейс репозитория для работы с моделью Human. 

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
       // public IActionResult Country(string name)
   //     {
       //     ViewData["human"] = _context.GetAllHumans(.ToList();
    //        return View();
    //    }
     //   public IAc
    }
}
