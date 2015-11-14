namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Created = c.DateTime(nullable: false),
                        Language = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        CurrentPicture_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pictures", t => t.CurrentPicture_Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.CurrentPicture_Id);
            
            CreateTable(
                "dbo.Audios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Url = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        Comment_Id = c.Long(),
                        FromUser_Id = c.String(maxLength: 128),
                        Audio_Id = c.Long(),
                        Picture_Id = c.Long(),
                        Post_Id = c.Long(),
                        Video_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.Comment_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.FromUser_Id)
                .ForeignKey("dbo.Audios", t => t.Audio_Id)
                .ForeignKey("dbo.Pictures", t => t.Picture_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .ForeignKey("dbo.Videos", t => t.Video_Id)
                .Index(t => t.Comment_Id)
                .Index(t => t.FromUser_Id)
                .Index(t => t.Audio_Id)
                .Index(t => t.Picture_Id)
                .Index(t => t.Post_Id)
                .Index(t => t.Video_Id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FromUser_Id = c.String(maxLength: 128),
                        Audio_Id = c.Long(),
                        Picture_Id = c.Long(),
                        Post_Id = c.Long(),
                        Video_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.FromUser_Id)
                .ForeignKey("dbo.Audios", t => t.Audio_Id)
                .ForeignKey("dbo.Pictures", t => t.Picture_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .ForeignKey("dbo.Videos", t => t.Video_Id)
                .Index(t => t.FromUser_Id)
                .Index(t => t.Audio_Id)
                .Index(t => t.Picture_Id)
                .Index(t => t.Post_Id)
                .Index(t => t.Video_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Url = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        IsReaded = c.Boolean(nullable: false),
                        User_Id = c.String(maxLength: 128),
                        User_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(),
                        Title = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        FromUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.FromUser_Id)
                .Index(t => t.FromUser_Id);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Url = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserUsers",
                c => new
                    {
                        User_Id = c.String(nullable: false, maxLength: 128),
                        User_Id1 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.User_Id, t.User_Id1 })
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Likes", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.Comments", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Likes", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Posts", "FromUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Pictures", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Messages", "User_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Messages", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserUsers", "User_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserUsers", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CurrentPicture_Id", "dbo.Pictures");
            DropForeignKey("dbo.Likes", "Picture_Id", "dbo.Pictures");
            DropForeignKey("dbo.Comments", "Picture_Id", "dbo.Pictures");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Audios", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Likes", "Audio_Id", "dbo.Audios");
            DropForeignKey("dbo.Likes", "FromUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Audio_Id", "dbo.Audios");
            DropForeignKey("dbo.Comments", "FromUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Comment_Id", "dbo.Comments");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.UserUsers", new[] { "User_Id1" });
            DropIndex("dbo.UserUsers", new[] { "User_Id" });
            DropIndex("dbo.Videos", new[] { "User_Id" });
            DropIndex("dbo.Posts", new[] { "FromUser_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.Messages", new[] { "User_Id1" });
            DropIndex("dbo.Messages", new[] { "User_Id" });
            DropIndex("dbo.Pictures", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "Video_Id" });
            DropIndex("dbo.Likes", new[] { "Post_Id" });
            DropIndex("dbo.Likes", new[] { "Picture_Id" });
            DropIndex("dbo.Likes", new[] { "Audio_Id" });
            DropIndex("dbo.Likes", new[] { "FromUser_Id" });
            DropIndex("dbo.Comments", new[] { "Video_Id" });
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            DropIndex("dbo.Comments", new[] { "Picture_Id" });
            DropIndex("dbo.Comments", new[] { "Audio_Id" });
            DropIndex("dbo.Comments", new[] { "FromUser_Id" });
            DropIndex("dbo.Comments", new[] { "Comment_Id" });
            DropIndex("dbo.Audios", new[] { "User_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "CurrentPicture_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.UserUsers");
            DropTable("dbo.Videos");
            DropTable("dbo.Posts");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.Messages");
            DropTable("dbo.Pictures");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.Likes");
            DropTable("dbo.Comments");
            DropTable("dbo.Audios");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
