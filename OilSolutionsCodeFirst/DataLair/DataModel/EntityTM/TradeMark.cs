using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair
{
    public class TradeMark
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }

        [ForeignKey("Logo")]
        public int LogoID { get; set; }
        public virtual Logo Logo { get; set; }

        public virtual List<TMBranch> TMBranches { get; set; }
        public TradeMark()
        {
            TMBranches = new List<TMBranch>();
        }
    }    
}
