using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    internal class Cocktail
    {
        public int CocktailID { get; set; }
        public string CocktailName { get; set; }

        public int? ContainerID { get; set; }
        public virtual Container CocktailContainer { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
