using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair
{
    public class TMBranch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }

        [ForeignKey("TradeMark")]
        public int TradeMarkID { get; set; }
        public virtual TradeMark TradeMark { get; set; }

        public virtual List<TMProduct> TMProducts { get; set; }
        public TMBranch()
        {
            TMProducts = new List<TMProduct>();
        }
    }
}
