using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public int IngredientAmount { get;set; }
        public string IngredientComment { get; set; }

        public int? UnitID { get; set; }
        public virtual Unit IngredientUnit { get; set; }
        public virtual ICollection<Cocktail> Cocktails { get; set;}
    }
}
