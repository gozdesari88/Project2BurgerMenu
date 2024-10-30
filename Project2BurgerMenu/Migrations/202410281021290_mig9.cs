﻿using System;
using System.Data.Entity.Migrations;

namespace Project2BurgerMenu.Migrations
{
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscribes",
                c => new
                {
                    SubscribeID = c.Int(nullable: false, identity: true),
                    SubscribeEmail = c.String(nullable: false),
                })
                .PrimaryKey(t => t.SubscribeID);
        }

        public override void Down()
        {
            DropTable("dbo.Subscribes");
        }
    }
}

