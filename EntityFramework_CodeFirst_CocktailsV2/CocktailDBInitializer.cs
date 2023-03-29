using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class CocktailDBInitializer : DropCreateDatabaseAlways<CocktailContext>
    {
        private readonly DbModelBuilder _modelBuilder;

        public CocktailDBInitializer(DbModelBuilder modelBuilder)
        {
            this._modelBuilder = modelBuilder;
        }

        public void Seed()
        {

        }

        protected override void Seed(CocktailContext context)
        {
            IList<Unit> units = new List<Unit>
            {
                new Unit() { UnitType = "ml" },         // 0
                new Unit() { UnitType = "segment" },    // 1
                new Unit() { UnitType = "rim" },        // 2
                new Unit() { UnitType = "tsp" },        // 3
                new Unit() { UnitType = "piece" },      // 4
                new Unit() { UnitType = "slice" },      // 5
                new Unit() { UnitType = "dash" },       // 6
                new Unit() { UnitType = "splash" },     // 7
                new Unit() { UnitType = "section" }     // 8
            };

            IList<Container> containers = new List<Container>
            {
                new Container() { ContainerType = "tall glass" },       // 0
                new Container() { ContainerType = "regular glass" },    // 1
                new Container() { ContainerType = "wide glass" },       // 2
                new Container() { ContainerType = "wine glass" },       // 3
                new Container() { ContainerType = "champagne glass" },  // 4
                new Container() { ContainerType = "cocktail glass" }    // 5
            };

            IList<Cocktail> cocktails = new List<Cocktail>
            {
                new Cocktail()
                {
                    CocktailName = "Margarita",
                    CocktailContainer = containers[2],
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient{ IngredientName = "jime juice", IngredientAmount = 60, IngredientComment = "", IngredientUnit = units[0] },
                        new Ingredient{ IngredientName = "triple sec", IngredientAmount = 30, IngredientComment = "", IngredientUnit =  units[0] },
                        new Ingredient{ IngredientName = "tequila", IngredientAmount = 60, IngredientComment = "", IngredientUnit =  units[0] },
                        new Ingredient{ IngredientName = "salt", IngredientAmount = 1, IngredientComment = "", IngredientUnit =  units[2] },
                        new Ingredient{ IngredientName = "ice cube", IngredientAmount = 1, IngredientComment = "crushed", IngredientUnit =  units[4] },
                        new Ingredient{ IngredientName = "lime", IngredientAmount = 1, IngredientComment = "", IngredientUnit =  units[1] }
                    }
                }
            };


            foreach (var unit in units)
            {
                context.Units.Add(unit);
            }
            foreach (var container in containers)
            {
                context.Containers.Add(container);
            }
            foreach (var cocktail in cocktails)
            {
                context.Cocktails.Add(cocktail);
            }

            //context.Units.AddRange(units);
            //context.Containers.AddRange(containers);
            //context.Cocktails.AddRange(cocktails);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
