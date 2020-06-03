using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPandemic4.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        //Смена поля  для выполнения домашнего задания номер 6
        //public string AuthorName { get; set; }
        public Human AuthorId { get; set; }
        public bool IsFake { get; set; }
    }
}
