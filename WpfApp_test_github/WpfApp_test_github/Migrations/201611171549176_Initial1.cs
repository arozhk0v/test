namespace WpfApp_test_github.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "rates_CAD", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "rates_GBP", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "rates_RUB", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "rates_USD", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "rates_USD");
            DropColumn("dbo.Products", "rates_RUB");
            DropColumn("dbo.Products", "rates_GBP");
            DropColumn("dbo.Products", "rates_CAD");
        }
    }
}
