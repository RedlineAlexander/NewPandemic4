using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPandemic4.Models.Repositories
{
    public class SqlNewsRepository : INewsRepositories
    {
        private InfestationContext infestationContext { get; set; }

        public SqlNewsRepository(InfestationContext infestationContext)
        {
            this.infestationContext = infestationContext;
        }

        public IEnumerable<News> GetAllNews()
        {
            return infestationContext.News;
            
           // throw new NotImplementedException();
        }
    }
}
