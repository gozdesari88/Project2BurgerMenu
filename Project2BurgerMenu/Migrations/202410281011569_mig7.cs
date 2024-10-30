using System;
using System.Data.Entity.Migrations;

namespace Project2BurgerMenu.Migrations
{
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                {
                    AboutID = c.Int(nullable: false, identity: true),
                    Subtitle = c.String(),
                    Title = c.String(),
                    Description = c.String(),
                    ImageUrl = c.String(),
                    Address = c.String(),
                    Phone = c.String(),
                    Email = c.String(),
                    MapLocation = c.String(),
                })
                .PrimaryKey(t => t.AboutID);
        }

        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
