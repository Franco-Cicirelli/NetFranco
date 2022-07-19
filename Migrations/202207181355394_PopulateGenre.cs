namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'History')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5,'Classic')");
        }
        
        public override void Down()
        {
        }
    }
}
