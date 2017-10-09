using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair
{
    public class DataContext : DbContext
    {
        public DbSet<Liquid> Liquids { get; set; }
        public DbSet<LiquidKaind> LiquidKainds { get; set; }
        public DbSet<ChemicalCategory> ChemicalCategories { get; set; }
        public DbSet<TradeMark> TradeMarks { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<TMBranch> TMBranches { get; set; }
        public DbSet<TMProduct> TMProducts { get; set; }
        public DbSet<ACEACategory> ACEACategories { get; set; }
        public DbSet<APICategory> APICategories { get; set; }
        public DbSet<ILSACCategory> ILSACCategories { get; set; }
        public DbSet<SAECategory> SAECategories { get; set; }

        public DbSet<AgrgateType> AgrgateTypes { get; set; }



        public DbSet<EngineConfiguration> EngineConfigurations { get; set; }
        public DbSet<EuropeanEmissionStandard> EuropeanEmissionStandards { get; set; }

    }
}
