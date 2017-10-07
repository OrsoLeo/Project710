using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilSolutionsCodeFirst.ModelDB
{
    public class Oil
    {
        public int OilId { get; set; }

        //public int CapacityId { get; set; }
        //[ForeignKey("CapacityId")]
        //public virtual Capacity Capacity { get; set; }
        [ForeignKey("Capacity")]
        public int CapacityId { get; set; }        
        public virtual Capacity Capacity { get; set; }
    }
}
