namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RemovedTownFromActorModelRemovedNameFromImageModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Actors", "BornTownId", "dbo.Towns");
            DropIndex("dbo.Actors", new[] { "BornTownId" });
            DropIndex("dbo.Images", new[] { "Name" });
            DropColumn("dbo.Actors", "BornTownId");
            DropColumn("dbo.Images", "Name");
        }

        public override void Down()
        {
            AddColumn("dbo.Images", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Actors", "BornTownId", c => c.Int());
            CreateIndex("dbo.Images", "Name", unique: true);
            CreateIndex("dbo.Actors", "BornTownId");
            AddForeignKey("dbo.Actors", "BornTownId", "dbo.Towns", "Id");
        }
    }
}