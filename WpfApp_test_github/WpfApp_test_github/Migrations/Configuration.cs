namespace WpfApp_test_github.Migrations
{
    using Newtonsoft.Json;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Policy;
    using WpfApp_test_github.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfApp_test_github.DB.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WpfApp_test_github.DB.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            ApplicationViewModel.Json = RequestSend.GET("http://api.fixer.io/latest?symbols=USD,GBP");

            ApplicationViewModel.Product_ = JsonConvert.DeserializeObject<Product>(ApplicationViewModel.Json);

            // Добавить в DbSet
            context.Products.AddOrUpdate(ApplicationViewModel.Product_);

            //context.Products.AddOrUpdate(p => p.Id,
            //      new Product { Base = "EUR",  Date = DateTime.Today}
            //    );

        }
    }
}
