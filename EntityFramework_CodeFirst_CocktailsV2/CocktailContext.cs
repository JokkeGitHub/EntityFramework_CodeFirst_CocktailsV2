using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;

namespace EntityFramework_CodeFirst_CocktailsV2
{
    public class CocktailContext : DbContext
    {
        // Your context has been configured to use a 'CocktailContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityFramework_CodeFirst_CocktailsV2.CocktailContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CocktailContext' 
        // connection string in the application configuration file.
        public CocktailContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyCocktailsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            //Database.SetInitializer(new CocktailDBInitializer());
        }

        public void SeedData()
        {
            CocktailDBInitializer cocktailDBInitializer = new CocktailDBInitializer();

            cocktailDBInitializer.SeedData(this);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CocktailConfigurations());

            //modelBuilder.Entity<Cocktail>().HasMany(i => i.Ingredients).WithMany(c => c.Cocktails);

            modelBuilder.Conventions.Add<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Container> Containers { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}