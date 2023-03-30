using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class Unit
    {
        public int UnitID { get; set; }
        public string UnitType { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
