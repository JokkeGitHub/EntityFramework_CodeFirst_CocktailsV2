using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    internal class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public int? UnitID { get; set; }
        public virtual Unit ItemUnit { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set;}
    }
}
