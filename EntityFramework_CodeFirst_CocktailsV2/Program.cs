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
            GetCocktails(dataAccess);
            Console.WriteLine("----------------------------------------------");

            DeleteCocktail(dataAccess);
            dataAccess = dataAccess.GetData(dataAccess);
            GetCocktails(dataAccess);
            Console.WriteLine("----------------------------------------------");

            CocktailsContainingVodka(dataAccess);

            Console.WriteLine("Ran without problems?");
            Console.ReadLine();

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

            void CocktailsContainingVodka(DataAccess dataAccess)
            {
                var query = from ingredient in dataAccess.Ingredients
                            where ingredient.IngredientItem.ItemName.Equals("vodka")
                            select ingredient.IngredientCocktail.CocktailName;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
