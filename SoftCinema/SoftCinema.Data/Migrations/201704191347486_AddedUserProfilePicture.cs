namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedUserProfilePicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProfilePictureId", c => c.Int());
            CreateIndex("dbo.Users", "ProfilePictureId");
            AddForeignKey("dbo.Users", "ProfilePictureId", "dbo.Images", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Users", "ProfilePictureId", "dbo.Images");
            DropIndex("dbo.Users", new[] { "ProfilePictureId" });
            DropColumn("dbo.Users", "ProfilePictureId");
        }
    }
}