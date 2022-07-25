namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBalanceToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Balance");
        }
    }
}
