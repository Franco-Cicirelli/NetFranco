namespace NetFranco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'94327f1a-a3a9-485d-8356-7a46544fd724', N'adminchichi@gmail.com', 0, N'AIDr08SaJuHxBKXlimWg65BHDS3k0WT6DLu7z6gf+UU5gqXR0Wze8FNh4kP2+D/xJg==', N'cef4ce54-5e4f-41c9-9573-8d3084544ed7', NULL, 0, 0, NULL, 1, 0, N'adminchichi@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1904ccb-8606-406e-a893-1355401e84dc', N'francocicirelli97@gmail.com', 0, N'AMpfzq/9qjZsGrETn35PBOPCmRQ5G/H7CbZE7pbFi5w5ri11urMEa+kugJrR5X154g==', N'08a92f41-15b1-4181-9406-a515ac525e13', NULL, 0, 0, NULL, 1, 0, N'francocicirelli97@gmail.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e63efceb-5ca0-4563-a94c-59032d585685', N'CanManageMovie')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'94327f1a-a3a9-485d-8356-7a46544fd724', N'e63efceb-5ca0-4563-a94c-59032d585685')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
