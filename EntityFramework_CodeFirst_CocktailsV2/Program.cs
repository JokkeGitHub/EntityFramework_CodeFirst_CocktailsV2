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
        static DataAccess dataAccess = new DataAccess();

        static void Initialization()
        {
            dataAccess.SeedData();
        }

        static void Main(string[] args)
        {
            Initialization();

            Console.WriteLine("GET ALL DATA");
            Console.WriteLine("----------------------------------------------");
            dataAccess = dataAccess.GetAllData(dataAccess);
            GetCocktails(dataAccess);
            Console.WriteLine("\n");

            Console.WriteLine("DELETE A COCKTAIL");
            Console.WriteLine("----------------------------------------------");
            DeleteCocktail(dataAccess);
            dataAccess = dataAccess.GetAllData(dataAccess);
            GetCocktails(dataAccess);
            Console.WriteLine("\n");


            Console.WriteLine("CREATE NEW COCKTAIL");
            Console.WriteLine("----------------------------------------------");
            CreateNewDrink(dataAccess);
            dataAccess = dataAccess.GetAllData(dataAccess);
            GetCocktails(dataAccess);

            Console.WriteLine("SEARCH FOR COCKTAILS BY INGREDIENT");
            Console.WriteLine("----------------------------------------------");
            SearchByIngredientName(dataAccess);
            Console.WriteLine("\n");

            Console.WriteLine("Ran without problems");
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

            void SearchByIngredientName(DataAccess dataAccess)
            {
                List<string> cocktailNames = dataAccess.GetCocktailByIngredient("vodka");

                foreach (var name in cocktailNames)
                {
                    Console.WriteLine(name);
                }

                cocktailNames.Clear();
            }

            void CreateNewDrink(DataAccess dataAccess)
            {
                Cocktail cocktail = new Cocktail() { CocktailName = "Entity Drink!!!Entity Drink!!!Entity Drink!!!Entity Drink!!!", CocktailContainer = dataAccess.Containers[0] };
                int newCocktailIndex = dataAccess.Cocktails.Count()-1;

                Ingredient ingredient1 = new Ingredient() { IngredientAmount = 20, IngredientComment = "", IngredientCocktail = dataAccess.Cocktails[newCocktailIndex], IngredientItem = dataAccess.Items[0] };
                Ingredient ingredient2 = new Ingredient() { IngredientAmount = 70, IngredientComment = "", IngredientCocktail = dataAccess.Cocktails[newCocktailIndex], IngredientItem = dataAccess.Items[15] };
                Ingredient ingredient3 = new Ingredient() { IngredientAmount = 2, IngredientComment = "crumbled", IngredientCocktail = dataAccess.Cocktails[newCocktailIndex], IngredientItem = dataAccess.Items[39] };

                List<Ingredient> ingredients = new List<Ingredient>
                {
                    ingredient1,
                    ingredient2,
                    ingredient3
                };

                dataAccess.CreateCocktail(cocktail, ingredients);
            }
        }
    }
}
