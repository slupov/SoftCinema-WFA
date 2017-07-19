namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedImageToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ImageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "ImageId");
            AddForeignKey("dbo.Movies", "ImageId", "dbo.Images", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "ImageId", "dbo.Images");
            DropIndex("dbo.Movies", new[] { "ImageId" });
            DropColumn("dbo.Movies", "ImageId");
        }
    }
}