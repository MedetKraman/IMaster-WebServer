using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class NewsLang
    {
        public int Id { get; set; }
        public string Langcode { get; set; }
        public string Title { get; set; }
        public string ShortText { get; set; }
        public string CoverUrl { get; set; }

        public int NewsId { get; set; }
        public virtual News News { get; set; }
    }
}
