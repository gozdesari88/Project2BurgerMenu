namespace Project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductName", c => c.String(maxLength: 100));
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryID", cascadeDelete: true);
            DropColumn("dbo.Products", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Name", c => c.String(maxLength: 100));
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropColumn("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "ProductName");
        }
    }
}
