namespace WpfApp_test_github.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Base = c.String(),
                        Date = c.DateTime(nullable: false),
                        rates_CAD = c.Double(nullable: false),
                        rates_GBP = c.Double(nullable: false),
                        rates_USD = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
