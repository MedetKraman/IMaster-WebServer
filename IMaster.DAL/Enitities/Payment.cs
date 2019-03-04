using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class Payment
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
    }
}
