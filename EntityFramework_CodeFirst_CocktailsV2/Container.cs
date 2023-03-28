using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class Container
    {
        public int ContainerID { get; set; }
        public string ContainerType { get; set; }

        public virtual ICollection<Cocktail> Cocktails { get; set; }
    }
}
