using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class CocktailDBInitializer : DropCreateDatabaseAlways<CocktailContext>
    {
        protected override void Seed(CocktailContext context)
        {
            //IList<Unit> units = new List<Unit>();

            //units.Add(new Unit())
        }
    }
}
