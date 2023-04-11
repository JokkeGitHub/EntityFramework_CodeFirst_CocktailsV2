using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{

    internal class DataAccess
    {
        public List<Unit> Units { get; set; }
        public List<Item> Items { get; set; }
        public List<Container> Containers { get; set; }
        public List<Cocktail> Cocktails { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public DataAccess()
        {    
        }

        public DataAccess GetData(DataAccess dataAccess)
        {
            using (var context = new CocktailContext())
            {
                dataAccess.Units = context.Units.ToList<Unit>();
                dataAccess.Items = context.Items.ToList<Item>();
                dataAccess.Containers = context.Containers.ToList<Container>();
                dataAccess.Cocktails = context.Cocktails.ToList<Cocktail>();
                dataAccess.Ingredients = context.Ingredients.ToList<Ingredient>();
            }

            return dataAccess;
        }

        public void DeleteCocktail(string cocktailToDeleteName)
        {

            using (var context = new CocktailContext())
            {
                var queryIngredients = from ingredient in context.Ingredients
                            where ingredient.IngredientCocktail.CocktailName.Equals(cocktailToDeleteName)
                            select ingredient;

                var queryCocktail = from cocktail in context.Cocktails
                             where cocktail.CocktailName.Equals(cocktailToDeleteName)
                             select cocktail;

                context.Ingredients.RemoveRange(queryIngredients);
                context.Cocktails.RemoveRange(queryCocktail);

                context.SaveChanges();
            }
        }
    }
}
