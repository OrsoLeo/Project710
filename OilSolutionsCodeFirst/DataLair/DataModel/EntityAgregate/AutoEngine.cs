using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair
{
    public class AutoEngine
    {
        public int ID { get; set; }

        [ForeignKey("TradeMark")]
        public int TradeMarkID { get; set; }
        public virtual TradeMark TradeMark { get; set; }

        public string Marking { get; set; }
        public int Year { get; set; }

        [ForeignKey("EngineConfiguration")]
        public int EngineConfigurationID { get; set; }
        public virtual EngineConfiguration EngineConfiguration { get; set; }
        
        public int CylinderQuantity { get; set; }
        public int CamshaftQuantity { get; set; }
        public int ValveQuantity { get; set; }
        public bool Turbo { get; set; }
        public int Power { get; set; }
        public int Torque { get; set; }
        public int Compression { get; set; }
        public double V { get; set; }
        public double OilCapacity { get; set; }


    }
}
