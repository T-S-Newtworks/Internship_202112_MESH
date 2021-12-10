namespace mesh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeImageModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "path", c => c.String());
            DropColumn("dbo.Images", "image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "image", c => c.Binary());
            DropColumn("dbo.Images", "path");
        }
    }
}
