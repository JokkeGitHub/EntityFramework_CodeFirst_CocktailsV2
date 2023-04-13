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

        public void SeedData()
        {
            CocktailContext cocktailContext = new CocktailContext();
            cocktailContext.SeedData();
        }

        public DataAccess GetAllData(DataAccess dataAccess)
        {
            using (var context = new CocktailContext())
            {
                /*
                var queryUnits = from unit in context.Units
                                 select unit;

                var queryItems = from item in context.Items
                                 select item;

                var queryContainers = from container in context.Containers
                                      select container;

                var queryCocktails = from cocktail in context.Cocktails
                                     select cocktail;

                var queryIngredients = from ingredient in context.Ingredients
                                       select ingredient;

                foreach (var unit in queryUnits)
                {
                    dataAccess.Units.Add(unit);
                }
                foreach (var item in queryItems)
                {
                    dataAccess.Items.Add(item);
                }
                foreach (var container in queryContainers)
                {
                    dataAccess.Containers.Add(container);
                }
                foreach (var cocktail in queryCocktails)
                {
                    dataAccess.Cocktails.Add(cocktail);
                }
                foreach (var ingredient in queryIngredients)
                {
                    dataAccess.Ingredients.Add(ingredient);
                }
                */
                if (dataAccess.Units != null)
                {
                    dataAccess.Units.Clear();
                }

                if (dataAccess.Items != null)
                {
                    dataAccess.Items.Clear();
                }

                if (dataAccess.Containers != null)
                {
                    dataAccess.Containers.Clear();
                }

                if (dataAccess.Cocktails != null)
                {
                    dataAccess.Cocktails.Clear();
                }

                if (dataAccess.Ingredients != null)
                {
                    dataAccess.Ingredients.Clear();
                }

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

        public List<string> GetCocktailByIngredient(string ingredientName)
        {
            List<string> cocktailNames = new List<string>();

            using (var context = new CocktailContext())
            {
                var query = from ingredient in context.Ingredients
                            where ingredient.IngredientItem.ItemName.Equals("vodka")
                            select ingredient.IngredientCocktail.CocktailName;

                foreach (var cocktailName in query)
                {
                    cocktailNames.Add(cocktailName);
                }
            }

            return cocktailNames;
        }

        public void CreateCocktail(Cocktail cocktail, List<Ingredient> ingredients)
        {
            using (var context = new CocktailContext())
            {
                context.Cocktails.Add(cocktail);
                context.Ingredients.AddRange(ingredients);
                
                context.SaveChanges();
            }
        }
    }
}
