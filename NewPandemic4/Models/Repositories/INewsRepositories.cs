using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPandemic4.Models.Repositories
{
    public interface INewsRepositories
    {

        public IEnumerable<News> GetAllNews();
    }
}
