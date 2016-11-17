namespace WpfApp_test_github.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "rates_RUB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "rates_RUB", c => c.Double(nullable: false));
        }
    }
}
