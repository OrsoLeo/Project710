using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair
{
    public class Liquid
    {
        public int ID { get; set; }

        [ForeignKey("LiquidKaind")]
        public int LiquidKaindID { get; set; }
        public virtual LiquidKaind LiquidKaind { get; set; }

        [ForeignKey("ChemicalCategory")]
        public int ChemicalCategoryID { get; set; }
        public virtual ChemicalCategory ChemicalCategory { get; set; }

        [ForeignKey("TradeMark")]
        public int TradeMarkID { get; set; }
        public virtual TradeMark TradeMark { get; set; }

        [ForeignKey("TMBranch")]
        public int TMBranchID { get; set; }
        public virtual TMBranch TMBranch { get; set; }

        [ForeignKey("TMProduct")]
        public int TMProductID { get; set; }
        public virtual TMProduct TMProduct { get; set; }

        [ForeignKey("ACEACategory")]
        public int ACEACategoryID { get; set; }
        public virtual ACEACategory ACEACategory { get; set; }

        [ForeignKey("APICategory")]
        public int APICategoryID { get; set; }
        public virtual APICategory APICategory { get; set; }

        [ForeignKey("ILSACCategory")]
        public int ILSACCategoryID { get; set; }
        public virtual ILSACCategory ILSACCategory { get; set; }

        [ForeignKey("SAECategory")]
        public int SAECategoryID { get; set; }
        public virtual SAECategory SAECategory { get; set; }
    }
}
