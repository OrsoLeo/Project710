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
    }
}
