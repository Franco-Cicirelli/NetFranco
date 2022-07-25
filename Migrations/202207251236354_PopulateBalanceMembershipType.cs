namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBalanceMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Balance = 100 WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Balance = 300 WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Balance = 500 WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Balance = 1000 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
