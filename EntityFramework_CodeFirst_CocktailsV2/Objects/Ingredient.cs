using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    internal class Ingredient
    {
        public int IngredientID { get; set; }
        public int IngredientAmount { get;set; }
        public string IngredientComment { get; set; }


        public int? ItemID { get; set; }
        public virtual Item IngredientItem { get; set; }
        public int? CocktailID { get; set; }
        public virtual Cocktail IngredientCocktail { get; set; }
    }
}
