namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthDateToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '05/01/1997 08:30:52' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '05/06/1991 10:30:52' WHERE Id = 2");
            Sql("UPDATE Customers SET BirthDate = '05/03/1994 10:30:52' WHERE Id = 3");
            Sql("UPDATE Customers SET BirthDate = '05/02/1999 10:30:52' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
