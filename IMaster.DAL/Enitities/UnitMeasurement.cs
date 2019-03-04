using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class UnitMeasurement
    {
        public UnitMeasurement()
        {
            UnitMeasurementLangs = new HashSet<UnitMeasurementLang>();
            ExecutorServices = new HashSet<ExecutorService>();
        }

        public int Id { get; set; }

        public ICollection<UnitMeasurementLang> UnitMeasurementLangs { get; set; }
        public ICollection<ExecutorService> ExecutorServices { get; set; }
    }
}
