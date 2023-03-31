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

        public DataAccess()
        {    
        }

        public DataAccess GetData(DataAccess dataAccess)
        {
            using (var context = new CocktailContext())
            {
                foreach (var unit in context.Units)
                {
                    dataAccess.Units.Add(unit); // This doesn't work either. 
                }
                /*
                foreach (var item in context.Items)
                {
                    this.Items.Add(item);
                }

                foreach (var container in context.Containers)
                {
                    this.Container.Add(container);
                }

                foreach (var cocktail in context.Cocktails)
                {
                    this.Cocktails.Add(cocktail);
                }

                foreach (var ingredient in context.Ingredients)
                {
                    this.Ingredients.Add(ingredient);
                }*/
            }

            return dataAccess;
        }
    }
}
