using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair
{
    public class EuropeanEmissionStandard
    {
        public int ID { get; set; }
        public string Marking { get; set; }
        public int Year { get; set; }
        public double CH { get; set; }
        public double CO { get; set; }
        public double NO { get; set; }
        public int AccordPeriod { get; set; }

    }
}
