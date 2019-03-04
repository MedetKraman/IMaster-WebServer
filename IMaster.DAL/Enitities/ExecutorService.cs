using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class ExecutorService
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }

        public int UnitMeasurementId { get; set; }
        public virtual UnitMeasurement UnitMeasurement { get; set; }

        public string ExecutorId { get; set; }
        public virtual ExecutorProfile Executor { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}
