namespace TedShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String());
        }
    }
}
