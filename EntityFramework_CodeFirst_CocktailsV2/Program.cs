using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    internal class Program
    {
        static CocktailContext cocktailContext = new CocktailContext();
        static DataAccess dataAccess = new DataAccess();

        static void Initialization()
        {
            cocktailContext.SeedData();
        }

        static void Main(string[] args)
        {            
            Initialization();

            dataAccess = dataAccess.GetData(dataAccess);

            /*
            foreach (var unit in dataAccess.Units)
            {
                Console.WriteLine(unit.UnitType);
            }
            foreach (var item in dataAccess.Items)
            {
                Console.WriteLine(item.ItemName);
            }
            foreach (var container in dataAccess.Containers)
            {
                Console.WriteLine(container.ContainerType);
            }
            foreach (var cocktail in dataAccess.Cocktails)
            {
                Console.WriteLine(cocktail.CocktailName);
            }
            foreach (var ingredient in dataAccess.Ingredients)
            {
                Console.WriteLine(ingredient.IngredientCocktail.CocktailName);
                Console.WriteLine(ingredient.IngredientItem.ItemName);
                Console.WriteLine(ingredient.IngredientAmount);
            }
            */


            GetCocktails(dataAccess);
            Console.WriteLine("----------------------------------------------");
            DeleteCocktail(dataAccess);
            GetCocktails(dataAccess);

            void GetCocktails(DataAccess dataAccess)
            { 
                var query = from cocktail in dataAccess.Cocktails
                            select cocktail;

                foreach (var cocktail in query)
                {
                    Console.WriteLine(cocktail.CocktailName);
                }
            }

            void DeleteCocktail(DataAccess dataAccess)
            {
                dataAccess.DeleteCocktail("Martini");
            }

            Console.WriteLine("Ran without problems?");
            Console.ReadLine();
        }
    }
}
