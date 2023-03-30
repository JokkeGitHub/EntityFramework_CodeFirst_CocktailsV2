using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
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

            */
            CocktailContext cocktailContext = new CocktailContext();
            cocktailContext.SeedData();

            Console.WriteLine("Ran without problems?");
            Console.ReadLine();

            /*
            Cocktail cocktailToDelete = new Cocktail
            {
                CocktailName = "Test",
                CocktailContainer = new Container { ContainerType = "Regular Glass" },
                Ingredients = new List<Ingredient>
                    {
                        new Ingredient{ IngredientName = "Tequila", IngredientAmount = 100, IngredientComment = "Stirred", IngredientUnit = new Unit{ UnitType = "ml"} },
                        new Ingredient{ IngredientName = "Lime", IngredientAmount = 1, IngredientComment = "Mushed", IngredientUnit = new Unit{ UnitType = "slice"} }
                    }
            };
            */

            /* BY ID's !!
            Cocktail cocktailToDelete = new Cocktail
            {
                CocktailName = "Test",
                ContainerID = 1,
                Ingredients = new List<Ingredient>
                    {
                        new Ingredient{ IngredientName = "Tequila", IngredientAmount = 100, IngredientComment = "Stirred", UnitID = 1 },
                        new Ingredient{ IngredientName = "Lime", IngredientAmount = 1, IngredientComment = "Mushed", UnitID = 2 }
                    }
            };
            */

            using (var context = new CocktailContext())
            {
                 //context.Cocktails.Remove(cocktailToDelete); //The object cannot be deleted because it was not found in the ObjectStateManager.
                //context.Entry(cocktailToDelete).State = EntityState.Deleted; 
                //When referring by object:
                // A referential integrity constraint violation occurred: The property value(s) of 'Container.ContainerID' on one end of a relationship do not match the property value(s) of 'Cocktail.ContainerID' on the other end.'
                //When referring by ID:
                // Attaching an entity of type 'EntityFramework_CodeFirst_CocktailsV2.Ingredient' failed because another entity of the same type already has the same primary key value. This can happen when using the 'Attach' method or setting the state of an entity to 'Unchanged' or 'Modified' if any entities in the graph have conflicting key values. This may be because some entities are new and have not yet received database-generated key values. In this case use the 'Add' method or the 'Added' entity state 

                context.SaveChanges();
            }

            //Console.WriteLine("Deleted without problems?");
            //Console.ReadLine();
        }
    }
}
