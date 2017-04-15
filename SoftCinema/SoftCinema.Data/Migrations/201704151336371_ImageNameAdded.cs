namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageNameAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Images", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Images", new[] { "Name" });
            DropColumn("dbo.Images", "Name");
        }
    }
}
