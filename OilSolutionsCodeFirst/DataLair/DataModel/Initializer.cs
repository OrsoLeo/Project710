using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLair.DataModel
{
    class Initializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            base.Seed(context);
        }
    }
}
