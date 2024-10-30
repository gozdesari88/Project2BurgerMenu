using System;
using System.Data.Entity.Migrations;

namespace Project2BurgerMenu.Migrations
{
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    ContactID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                    MessageDetail = c.String(),
                    SendDate = c.DateTime(nullable: false),
                    IsRead = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ContactID);
        }

        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
