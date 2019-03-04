using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class Service
    {
        public Service()
        {
            ServiceLangs = new HashSet<ServiceLang>();
            ExecutorServices = new HashSet<ExecutorService>();
        }

        public int Id { get; set; }

        public ICollection<ServiceLang> ServiceLangs { get; set; }
        public ICollection<ExecutorService> ExecutorServices { get; set; }
    }
}
