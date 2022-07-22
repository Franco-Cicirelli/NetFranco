﻿namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
            AlterColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            AlterColumn("dbo.Rentals", "Movie_Id", c => c.Int());
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
