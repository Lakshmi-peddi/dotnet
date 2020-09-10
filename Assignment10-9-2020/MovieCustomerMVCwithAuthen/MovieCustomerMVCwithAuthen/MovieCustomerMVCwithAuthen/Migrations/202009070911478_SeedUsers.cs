namespace MovieCustomerMVCwithAuthen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'4aa99d3d-e3ff-4d14-ba74-61b2dc8dd719', N'lakshmipeddi50@gmail.com', 0, N'AANo+bBiEh2uUpq5MWWVH25D6IVMktvfKf5z/f/y7SCfV/O8DME2pGGYaM5+AW1xew==', N'4c91ebad-83e9-4d4a-8127-937685fa9c9f', NULL, 0, 0, NULL, 1, 0, N'lakshmipeddi50@gmail.com', N'123456789')')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be718e2a-66ea-42c4-be72-df14cf2a55a9', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2c6f32de-d913-4b2c-87b5-3c3270f96ac7', N'be718e2a-66ea-42c4-be72-df14cf2a55a9')");
        }
        
        public override void Down()
        {
        }
    }
}
