namespace mesh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20211208 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Passward = c.String(),
                        Name = c.String(maxLength: 256),
                        Icon = c.Binary(),
                        Authority_Id = c.Int(),
                        Base_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authorities", t => t.Authority_Id)
                .ForeignKey("dbo.Bases", t => t.Base_Id)
                .Index(t => t.Authority_Id)
                .Index(t => t.Base_Id);
            
            CreateTable(
                "dbo.Appllies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Appllytype = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Authorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 2000),
                        Date = c.DateTime(nullable: false),
                        ChannelNo_Id = c.Int(),
                        Image_ID = c.Int(),
                        Tag_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Channels", t => t.ChannelNo_Id)
                .ForeignKey("dbo.Images", t => t.Image_ID)
                .ForeignKey("dbo.Tags", t => t.Tag_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.ChannelNo_Id)
                .Index(t => t.Image_ID)
                .Index(t => t.Tag_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        image = c.Binary(),
                        dateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.Image_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Image_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Likes", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Likes", "Image_ID", "dbo.Images");
            DropForeignKey("dbo.Chats", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Chats", "Tag_ID", "dbo.Tags");
            DropForeignKey("dbo.Chats", "Image_ID", "dbo.Images");
            DropForeignKey("dbo.Chats", "ChannelNo_Id", "dbo.Channels");
            DropForeignKey("dbo.Users", "Base_Id", "dbo.Bases");
            DropForeignKey("dbo.Users", "Authority_Id", "dbo.Authorities");
            DropForeignKey("dbo.Appllies", "User_ID", "dbo.Users");
            DropIndex("dbo.Likes", new[] { "User_ID" });
            DropIndex("dbo.Likes", new[] { "Image_ID" });
            DropIndex("dbo.Chats", new[] { "User_ID" });
            DropIndex("dbo.Chats", new[] { "Tag_ID" });
            DropIndex("dbo.Chats", new[] { "Image_ID" });
            DropIndex("dbo.Chats", new[] { "ChannelNo_Id" });
            DropIndex("dbo.Appllies", new[] { "User_ID" });
            DropIndex("dbo.Users", new[] { "Base_Id" });
            DropIndex("dbo.Users", new[] { "Authority_Id" });
            DropTable("dbo.Likes");
            DropTable("dbo.Tags");
            DropTable("dbo.Images");
            DropTable("dbo.Channels");
            DropTable("dbo.Chats");
            DropTable("dbo.Bases");
            DropTable("dbo.Authorities");
            DropTable("dbo.Appllies");
            DropTable("dbo.Users");
        }
    }
}
