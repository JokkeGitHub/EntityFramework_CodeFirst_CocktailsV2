using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    internal class CocktailConfigurations : EntityTypeConfiguration<Cocktail>
    {
        public CocktailConfigurations()
        {
            this.Property(c => c.CocktailName).IsRequired().HasMaxLength(70);
            this.Property(c => c.CocktailName).IsConcurrencyToken();
        }
    }
}
