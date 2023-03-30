using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class CocktailDBInitializer : DropCreateDatabaseAlways<CocktailContext>
    {
        public void SeedData(CocktailContext context)
        {
            IList<Container> containers = new List<Container>
            {
                new Container() { ContainerType = "old fashioned glass" },  // 0
                new Container() { ContainerType = "highball glass" },       // 1
                new Container() { ContainerType = "martini glass" },        // 2
                new Container() { ContainerType = "collins glass" },        // 3
                new Container() { ContainerType = "hurricane glass" },      // 4
                new Container() { ContainerType = "champagne flute glass" } // 5
            };

            IList<Cocktail> cocktails = new List<Cocktail>
            {
                new Cocktail() { CocktailName = "Margarita", CocktailContainer = containers[0] },       // 1
                new Cocktail() { CocktailName = "Mai Tai", CocktailContainer = containers[0] },         // 2
                new Cocktail() { CocktailName = "White Russian", CocktailContainer = containers[0] },   // 3
                new Cocktail() { CocktailName = "Caipirinha", CocktailContainer = containers[0] },      // 4
                new Cocktail() { CocktailName = "Screwdriver", CocktailContainer = containers[1] },     // 5
                new Cocktail() { CocktailName = "Bloody Mary", CocktailContainer = containers[1] },     // 6
                new Cocktail() { CocktailName = "Whiskey Sour", CocktailContainer = containers[1] },    // 7
                new Cocktail() { CocktailName = "Old Fashioned", CocktailContainer = containers[0] },   // 8
                new Cocktail() { CocktailName = "Manhatten", CocktailContainer = containers[2] },       // 9
                new Cocktail() { CocktailName = "Martini", CocktailContainer = containers[2] },         // 10
                new Cocktail() { CocktailName = "Daiquiri", CocktailContainer = containers[2] },        // 11
                new Cocktail() { CocktailName = "Cosmopolitan", CocktailContainer = containers[2] },    // 12
                new Cocktail() { CocktailName = "Singapore Sling", CocktailContainer = containers[3] }, // 13
                new Cocktail() { CocktailName = "Mojito", CocktailContainer = containers[3] },          // 14
                new Cocktail() { CocktailName = "Mint Julep", CocktailContainer = containers[3] },      // 15
                new Cocktail() { CocktailName = "Tom Collins", CocktailContainer = containers[3] },     // 16
                new Cocktail() { CocktailName = "Pina Colada", CocktailContainer = containers[4] },     // 17
                new Cocktail() { CocktailName = "Sea Breeze", CocktailContainer = containers[3] },      // 18
                new Cocktail() { CocktailName = "Cuba Libre", CocktailContainer = containers[3] },      // 19
                new Cocktail() { CocktailName = "Bellini", CocktailContainer = containers[5] }          // 20
            };

            IList<Unit> units = new List<Unit>
            {
                new Unit() { UnitType = "ml" },      // 0
                new Unit() { UnitType = "rim" },     // 1
                new Unit() { UnitType = "tsp" },     // 2
                new Unit() { UnitType = "piece" },   // 3
                new Unit() { UnitType = "dash" },    // 4
                new Unit() { UnitType = "splash" },  // 5
            };

            IList<Item> items = new List<Item>
            {
                new Item() { ItemName = "lime juice", ItemUnit = units[0] },            // 0
                new Item() { ItemName = "triple sec", ItemUnit = units[0] },            // 1
                new Item() { ItemName = "tequila", ItemUnit = units[0] },               // 2
                new Item() { ItemName = "salt", ItemUnit = units[1] },                  // 3
                new Item() { ItemName = "ice cube", ItemUnit = units[3] },              // 4
                new Item() { ItemName = "lime segment", ItemUnit = units[3] },          // 5
                new Item() { ItemName = "peach puree", ItemUnit = units[0] },           // 6
                new Item() { ItemName = "prosecco", ItemUnit = units[0] },              // 7
                new Item() { ItemName = "dark rum", ItemUnit = units[0] },              // 8
                new Item() { ItemName = "orange curacao", ItemUnit = units[0] },        // 9
                new Item() { ItemName = "almond syrup", ItemUnit = units[0] },          // 10
                new Item() { ItemName = "lime section", ItemUnit = units[3] },          // 11
                new Item() { ItemName = "maraschino cherry", ItemUnit = units[3] },     // 12
                new Item() { ItemName = "fresh cream", ItemUnit = units[0] },           // 13
                new Item() { ItemName = "kahlua", ItemUnit = units[0] },                // 14
                new Item() { ItemName = "vodka", ItemUnit = units[0] },                 // 15
                new Item() { ItemName = "cachaca", ItemUnit = units[0] },               // 16
                new Item() { ItemName = "caster sugar", ItemUnit = units[2] },          // 17
                new Item() { ItemName = "orange juice", ItemUnit = units[0] },          // 18
                new Item() { ItemName = "tomato juice", ItemUnit = units[0] },          // 19
                new Item() { ItemName = "celery stick", ItemUnit = units[3] },          // 20
                new Item() { ItemName = "worcestershire sauce", ItemUnit = units[5] },  // 21
                new Item() { ItemName = "bourbon", ItemUnit = units[0] },               // 22
                new Item() { ItemName = "water", ItemUnit = units[0] },                 // 23
                new Item() { ItemName = "cube caster sugar", ItemUnit = units[3] },     // 24
                new Item() { ItemName = "angostura bitters", ItemUnit = units[4] },     // 25
                new Item() { ItemName = "orange peel", ItemUnit = units[3] },           // 26
                new Item() { ItemName = "italian sweet vermouth", ItemUnit = units[0] },// 27
                new Item() { ItemName = "french dry vemouth", ItemUnit = units[0] },    // 28
                new Item() { ItemName = "gin", ItemUnit = units[0] },                   // 29
                new Item() { ItemName = "olive", ItemUnit = units[3] },                 // 30
                new Item() { ItemName = "white rum", ItemUnit = units[0] },             // 31
                new Item() { ItemName = "brown sugar", ItemUnit = units[2] },           // 32
                new Item() { ItemName = "pink grapefruit juice", ItemUnit = units[0] }, // 33
                new Item() { ItemName = "cranberry juice", ItemUnit = units[0] },       // 34
                new Item() { ItemName = "soda", ItemUnit = units[0] },                  // 35
                new Item() { ItemName = "cherry brandy", ItemUnit = units[0] },         // 36
                new Item() { ItemName = "sloe gin", ItemUnit = units[0] },              // 37
                new Item() { ItemName = "orange segment", ItemUnit = units[3] },        // 38
                new Item() { ItemName = "mint leaf", ItemUnit = units[3] },             // 39
                new Item() { ItemName = "soda water", ItemUnit = units[5] },            // 40
                new Item() { ItemName = "orange slice", ItemUnit = units[3] },          // 41
                new Item() { ItemName = "pineapple juice", ItemUnit = units[0] },       // 42
                new Item() { ItemName = "coconut cream", ItemUnit = units[0] },         // 43
                new Item() { ItemName = "pineapple segment", ItemUnit = units[3] },     // 44
                new Item() { ItemName = "grapefruit juice", ItemUnit = units[0] },      // 45
                new Item() { ItemName = "cola", ItemUnit = units[0] },                  // 46
                new Item() { ItemName = "cointreau", ItemUnit = units[0] },             // 47
            };

            IList<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient() {IngredientAmount = 60, IngredientComment = "", IngredientCocktail = cocktails[0], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 30, IngredientComment = "", IngredientCocktail = cocktails[0], IngredientItem = items[1]},
                new Ingredient() {IngredientAmount = 60, IngredientComment = "", IngredientCocktail = cocktails[0], IngredientItem = items[2]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[0], IngredientItem = items[3]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "crushed", IngredientCocktail = cocktails[0], IngredientItem = items[4]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[0], IngredientItem = items[5]},

                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[8]},
                new Ingredient() {IngredientAmount = 15, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[9]},
                new Ingredient() {IngredientAmount = 10, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 60, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[10]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[11]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[12]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[1], IngredientItem = items[5]},

                new Ingredient() {IngredientAmount = 30, IngredientComment = "", IngredientCocktail = cocktails[2], IngredientItem = items[13]},
                new Ingredient() {IngredientAmount = 30, IngredientComment = "", IngredientCocktail = cocktails[2], IngredientItem = items[14]},
                new Ingredient() {IngredientAmount = 90, IngredientComment = "", IngredientCocktail = cocktails[2], IngredientItem = items[15]},

                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[3], IngredientItem = items[16]},
                new Ingredient() {IngredientAmount = 5, IngredientComment = "", IngredientCocktail = cocktails[3], IngredientItem = items[5]},
                new Ingredient() {IngredientAmount = 2, IngredientComment = "", IngredientCocktail = cocktails[3], IngredientItem = items[17]},

                new Ingredient() {IngredientAmount = 135, IngredientComment = "", IngredientCocktail = cocktails[4], IngredientItem = items[18]},
                new Ingredient() {IngredientAmount = 45, IngredientComment = "", IngredientCocktail = cocktails[4], IngredientItem = items[15]},

                new Ingredient() {IngredientAmount = 135, IngredientComment = "", IngredientCocktail = cocktails[5], IngredientItem = items[19]},
                new Ingredient() {IngredientAmount = 45, IngredientComment = "", IngredientCocktail = cocktails[5], IngredientItem = items[15]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[5], IngredientItem = items[4]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[5], IngredientItem = items[20]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[5], IngredientItem = items[21]},

                new Ingredient() {IngredientAmount = 90, IngredientComment = "", IngredientCocktail = cocktails[6], IngredientItem = items[22]},
                new Ingredient() {IngredientAmount = 40, IngredientComment = "", IngredientCocktail = cocktails[6], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[6], IngredientItem = items[12]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[6], IngredientItem = items[41]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[6], IngredientItem = items[32]},

                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[7], IngredientItem = items[22]},
                new Ingredient() {IngredientAmount = 5, IngredientComment = "", IngredientCocktail = cocktails[7], IngredientItem = items[23]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[7], IngredientItem = items[24]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[7], IngredientItem = items[25]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[7], IngredientItem = items[26]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[7], IngredientItem = items[4]},

                new Ingredient() {IngredientAmount = 25, IngredientComment = "", IngredientCocktail = cocktails[8], IngredientItem = items[27]},
                new Ingredient() {IngredientAmount = 45, IngredientComment = "", IngredientCocktail = cocktails[8], IngredientItem = items[22]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[8], IngredientItem = items[12]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[8], IngredientItem = items[25]},

                new Ingredient() {IngredientAmount = 25, IngredientComment = "", IngredientCocktail = cocktails[9], IngredientItem = items[28]},
                new Ingredient() {IngredientAmount = 45, IngredientComment = "", IngredientCocktail = cocktails[9], IngredientItem = items[29]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[9], IngredientItem = items[30]},

                new Ingredient() {IngredientAmount = 25, IngredientComment = "", IngredientCocktail = cocktails[10], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 45, IngredientComment = "", IngredientCocktail = cocktails[10], IngredientItem = items[31]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[10], IngredientItem = items[32]},

                new Ingredient() {IngredientAmount = 15, IngredientComment = "", IngredientCocktail = cocktails[11], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 15, IngredientComment = "", IngredientCocktail = cocktails[11], IngredientItem = items[33]},
                new Ingredient() {IngredientAmount = 15, IngredientComment = "", IngredientCocktail = cocktails[11], IngredientItem = items[34]},
                new Ingredient() {IngredientAmount = 15, IngredientComment = "", IngredientCocktail = cocktails[11], IngredientItem = items[47]},
                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[11], IngredientItem = items[15]},

                new Ingredient() {IngredientAmount = 250, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[35]},
                new Ingredient() {IngredientAmount = 20, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[36]},
                new Ingredient() {IngredientAmount = 20, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 20, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[37]},
                new Ingredient() {IngredientAmount = 45, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[29]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[38]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[12], IngredientItem = items[32]},

                new Ingredient() {IngredientAmount = 20, IngredientComment = "", IngredientCocktail = cocktails[13], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[13], IngredientItem = items[31]},
                new Ingredient() {IngredientAmount = 10, IngredientComment = "", IngredientCocktail = cocktails[13], IngredientItem = items[39]},
                new Ingredient() {IngredientAmount = 2, IngredientComment = "", IngredientCocktail = cocktails[13], IngredientItem = items[17]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "crushed", IngredientCocktail = cocktails[13], IngredientItem = items[4]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[13], IngredientItem = items[40]},

                new Ingredient() {IngredientAmount = 300, IngredientComment = "", IngredientCocktail = cocktails[14], IngredientItem = items[23]},
                new Ingredient() {IngredientAmount = 60, IngredientComment = "", IngredientCocktail = cocktails[14], IngredientItem = items[22]},
                new Ingredient() {IngredientAmount = 4, IngredientComment = "", IngredientCocktail = cocktails[14], IngredientItem = items[39]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[14], IngredientItem = items[32]},
                new Ingredient() {IngredientAmount = 4, IngredientComment = "crushed", IngredientCocktail = cocktails[14], IngredientItem = items[4]},

                new Ingredient() {IngredientAmount = 220, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[35]},
                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[29]},
                new Ingredient() {IngredientAmount = 25, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[12]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[41]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[32]},
                new Ingredient() {IngredientAmount = 3, IngredientComment = "", IngredientCocktail = cocktails[15], IngredientItem = items[4]},

                new Ingredient() {IngredientAmount = 70, IngredientComment = "", IngredientCocktail = cocktails[16], IngredientItem = items[42]},
                new Ingredient() {IngredientAmount = 30, IngredientComment = "", IngredientCocktail = cocktails[16], IngredientItem = items[31]},
                new Ingredient() {IngredientAmount = 60, IngredientComment = "", IngredientCocktail = cocktails[16], IngredientItem = items[43]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[16], IngredientItem = items[44]},

                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[17], IngredientItem = items[45]},
                new Ingredient() {IngredientAmount = 120, IngredientComment = "", IngredientCocktail = cocktails[17], IngredientItem = items[34]},
                new Ingredient() {IngredientAmount = 40, IngredientComment = "", IngredientCocktail = cocktails[17], IngredientItem = items[15]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[17], IngredientItem = items[4]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[17], IngredientItem = items[5]},

                new Ingredient() {IngredientAmount = 80, IngredientComment = "", IngredientCocktail = cocktails[18], IngredientItem = items[46]},
                new Ingredient() {IngredientAmount = 25, IngredientComment = "", IngredientCocktail = cocktails[18], IngredientItem = items[0]},
                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[18], IngredientItem = items[31]},
                new Ingredient() {IngredientAmount = 1, IngredientComment = "", IngredientCocktail = cocktails[18], IngredientItem = items[4]},

                new Ingredient() {IngredientAmount = 50, IngredientComment = "", IngredientCocktail = cocktails[19], IngredientItem = items[6]},
                new Ingredient() {IngredientAmount = 100, IngredientComment = "", IngredientCocktail = cocktails[19], IngredientItem = items[7]},
            };

            context.Containers.AddRange(containers);
            context.Cocktails.AddRange(cocktails);
            context.Units.AddRange(units);
            context.Items.AddRange(items);
            context.Ingredients.AddRange(ingredients);

            context.SaveChanges();
        }
        protected override void Seed(CocktailContext context)
        {
            /*

            */


            /*
            */
            //
            //
            //
            //
            //base.Seed(context);
        }
    }
}
