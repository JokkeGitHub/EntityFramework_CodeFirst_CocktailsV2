using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var context = new CocktailContext()) 
            {
                context.Cocktails.Add(new Cocktail
                {
                    CocktailName = "Test",
                    CocktailContainer = new Container { ContainerType = "Regular Glass" },
                    Ingredients = new List<Ingredient> 
                    { 
                        new Ingredient{ IngredientName = "Tequila", IngredientAmount = 100, IngredientComment = "Stirred", IngredientUnit = new Unit{ UnitType = "ml"} },
                        new Ingredient{ IngredientName = "Lime", IngredientAmount = 1, IngredientComment = "Mushed", IngredientUnit = new Unit{ UnitType = "slice"} }
                    }
                });

                context.SaveChanges();
            }

            Console.WriteLine("Ran without problems?");
            Console.ReadLine();
        }
    }
}
