using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class News
    {
        public News()
        {
            NewsLangs = new HashSet<NewsLang>();
        }

        public int Id { get; set; }
        public int ViewsNumber { get; set; }
        public DateTime PublishDateTime { get; set; }

        public ICollection<NewsLang> NewsLangs { get; set; }
    }
}
