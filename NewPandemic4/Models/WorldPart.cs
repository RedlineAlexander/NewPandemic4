using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * Создайте модель WorldPart с полямя Id Name, установите связь с моделью Country, так как считаете правильным. Обновите базу.
Заполните таблицу WorldParts значениями всех частей мира (всего 6). При этом используйте метод OnModelCreating.
 */
namespace NewPandemic4.Models
{
    public class WorldPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //В ЧЕМ РАЗНИЦА???
        //public List<Country> Countries { get; set; }

        public Country Country { get; set; }
    }
}
