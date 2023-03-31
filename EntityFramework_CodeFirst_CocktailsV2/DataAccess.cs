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
        public List<Container> Container { get; set; }
        public List<Cocktail> Cocktails { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public DataAccess() { }

        public List<List<object>> GetData(List<List<object>> lists)
        {
            using (var context = new CocktailContext())
            {
                foreach (var unit in context.Units)
                {
                    lists[0].Add(unit); // This doesn't work. Maybe add some temp lists of correct type here
                    // Maybe I should just add a class which consists of the correct list types? This might be a better solution
                }

                foreach (var item in context.Items)
                {
                    lists[1].Add(item);
                }

                foreach (var container in context.Containers)
                {
                    lists[2].Add(container);
                }

                foreach (var cocktail in context.Cocktails)
                {
                    lists[3].Add(cocktail);
                }

                foreach (var ingredient in context.Ingredients)
                {
                    lists[4].Add(ingredient);
                }
            }

            return lists;
        }
    }
}
