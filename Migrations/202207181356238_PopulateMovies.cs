namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {

            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateJoined, GenreId,Stock) VALUES (1, 'The God Father I', '05/01/1971 08:30:52', '05/07/2022 08:30:52', 5,10)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateJoined, GenreId,Stock) VALUES (2, 'The God Father II', '05/01/1974 08:30:52', '05/07/2022 08:30:52', 5,10)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateJoined, GenreId,Stock) VALUES (3, 'The God Father III', '05/01/1977 08:30:52', '05/07/2022 08:30:52', 5,10)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateJoined, GenreId,Stock) VALUES (4, 'Titanic', '05/01/1991 08:30:52', '05/07/2022 08:30:52', 4,15)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateJoined, GenreId,Stock) VALUES (5, 'The Truman Show', '05/01/1998 08:30:52', '05/07/2022 08:30:52', 2,20)");
        }
        
        public override void Down()
        {
        }
    }
}
