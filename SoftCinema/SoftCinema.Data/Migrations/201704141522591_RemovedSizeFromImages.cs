namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedSizeFromImages : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Images", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Size", c => c.Int(nullable: false));
        }
    }
}
