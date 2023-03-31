using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{

    internal class DataAccess
    {
        // Let's try this instead
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
    }
}
