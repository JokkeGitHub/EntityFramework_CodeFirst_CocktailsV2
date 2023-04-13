using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    internal class CocktailContext : DbContext
    {
        public CocktailContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyCocktailsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<CocktailContext>());
        }

        public void SeedData()
        {
            CocktailDBInitializer cocktailDBInitializer = new CocktailDBInitializer();

            cocktailDBInitializer.SeedData(this);
        }

        public DbSet<Container> Containers { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}