namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8038439b-8dbf-4534-89f0-dbea7722b89e', N'guest@vidly.com', 0, N'AOq4AqrXcjTHabhlckTdKvKuJTfi4joDm9UkI2lcGfT1jxkCijZJ3hEM6LA0AJsK5w==', N'f0f4f7bd-78ac-49b5-8afc-bc53d81b301f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dabce8ea-8db0-435f-b0de-6c5dd81ec7c4', N'admin@vidly.com', 0, N'AK9jq74S42nm7Yv32z/1s3EvfSOw85OANEI44L9MXheAezMJqOL91CWszGq2AXxvKg==', N'6a44889b-4c82-4abe-8d43-e839d04b1be1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0d583d1a-2b9e-4f34-8daf-c41469cde9f9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dabce8ea-8db0-435f-b0de-6c5dd81ec7c4', N'0d583d1a-2b9e-4f34-8daf-c41469cde9f9')

");
        }
        
        public override void Down()
        {
        }
    }
}
